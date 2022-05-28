using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using MimeKit.Text;
using MailKit.Net.Smtp;

namespace SmokyMailerPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly SmtpClient client = new SmtpClient();
        int count;

        private void BtnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "TEXT Files(*.txt)|*.txt|CSV Files(*.csv)|*.csv"
            };

            DialogResult dial = ofd.ShowDialog();

            if( dial == DialogResult.OK )
            {
                StreamReader sr = new StreamReader(@ofd.FileName);
                string line;
                
                while((line = sr.ReadLine()) != null)
                {
                    LstMail.Items.Add(line);
                }

                sr.Close();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            BtnSend.Enabled = false;
            pictureBox1.Enabled = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BtnSend.Enabled = true;
            pictureBox1.Enabled = false;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;


            try
            {
                SmtpClient client = new SmtpClient
                {
                    Timeout = 3000
                };
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Connect(TxtHost.Text, int.Parse(TxtPort.Text));
                client.Authenticate(TxtUser.Text, TxtPass.Text);

                
                    MimeMessage mime = new MimeMessage();
                    BodyBuilder builder = new BodyBuilder();
                    
                    for (int i = 0; i < (int)numericUpDown1.Value; i++)
                    {
                        mime.From.Add(new MailboxAddress(TxtName.Text, TxtUser.Text));
                        mime.Subject = TxtSbj.Text;
                        builder.TextBody = RichTextBox1.Text;

                    if (fl.FileName != string.Empty)
                    {
                        builder.Attachments.Add(@fl.FileName);
                    }
                    mime.Body = builder.ToMessageBody();

                    foreach (string str in LstMail.Items)
                        {
                           
                           mime.To.Add(MailboxAddress.Parse(str));

                        }

                        client.Send(mime);
                        Thread.Sleep(1000);
                    }
                client.Disconnect(true);

                count++;
                int a = LstMail.Items.Count;

                int b = a * count;

                LblCount.Text = b.ToString();

            }
            catch (Exception exxi)
            {
                MessageBox.Show(exxi.Message);
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (FontFamily ff in FontFamily.Families)
            {
                CmbStyle.Items.Add(ff.Name.ToString());
                
            }
            
        }

        private void CmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            RichTextBox1.Font = new Font(CmbStyle.Text, RichTextBox1.Font.Size);

        }
        private void CmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            RichTextBox1.Font = new Font(RichTextBox1.Font.FontFamily, float.Parse(CmbSize.SelectedItem.ToString()));
            
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            //Font bold;
            FontStyle noBold;
 
            if (RichTextBox1.SelectionFont.Bold == true)
                noBold = FontStyle.Regular;
            else
                noBold = FontStyle.Bold;

            RichTextBox1.SelectionFont = new Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, noBold);
        }

        private void BtnStrike_Click(object sender, EventArgs e)
        {
            //Font strike;
            FontStyle noStrike;

            if (RichTextBox1.SelectionFont.Strikeout == true)
                noStrike = FontStyle.Regular;
            else
                noStrike = FontStyle.Strikeout;

            RichTextBox1.SelectionFont = new Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, noStrike);
        }

        private void BtnItalic_Click(object sender, EventArgs e)
        {
            //Font italic;
            FontStyle noItalic;

            if (RichTextBox1.SelectionFont.Italic == true)
                noItalic = FontStyle.Regular;
            else
                noItalic = FontStyle.Italic;

            RichTextBox1.SelectionFont = new Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, noItalic);
        }

        private void BtnUnder_Click(object sender, EventArgs e)
        {
            //Font under;
            FontStyle noUnder;

            if (RichTextBox1.SelectionFont.Underline == true)
                noUnder = FontStyle.Regular;
            else
                noUnder = FontStyle.Underline;

            RichTextBox1.SelectionFont = new Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, noUnder);
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
                client.Dispose();
                BtnSend.Enabled = true;
                pictureBox1.Enabled = false;
            
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            LblCount.Text = "0";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LstMail.Items.Clear();
            LblCount.Text = "0";
        }

        readonly OpenFileDialog fl = new OpenFileDialog();
        
        private void BtnAttach_Click(object sender, EventArgs e)
        {
             fl.Multiselect = false;
             fl.Filter = "All Files (*.*)|*.*";

            
            DialogResult dl = fl.ShowDialog();

            if (dl == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(@fl.FileName);
                TxtFile.Text = fl.FileName;
                sr.Close();
            }
            
        }

        private void BtnSmtp_Click(object sender, EventArgs e)
        {
            TxtHost.Clear();
            TxtUser.Clear();
            TxtName.Clear();
            TxtPass.Clear();
            TxtPort.Clear();
            numericUpDown1.Value = 0;
        }

        private void CheckSsl_CheckedChanged(object sender, EventArgs e)
        {
            SmtpClient client1 = new SmtpClient();
            if (CheckSsl.Checked)
                client1.SslProtocols = System.Security.Authentication.SslProtocols.Default;
        }
    }
}
