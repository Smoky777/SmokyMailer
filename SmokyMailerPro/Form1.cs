using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        readonly int b = 0;


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

                if (LstMail.Text != null)
                {
                    MimeMessage mime = new MimeMessage();
                    BodyBuilder builder = new BodyBuilder();
                    
                    for (int i = 0; i < (int)numericUpDown1.Value; i++)
                    {
                        mime.From.Add(new MailboxAddress(TxtName.Text, TxtUser.Text));
                        mime.Subject = TxtSbj.Text;
                        builder.TextBody = RichTextBox1.Text;
                        mime.Body = builder.ToMessageBody();

                        foreach (string str in LstMail.Items)
                        {
                           
                            mime.To.Add(MailboxAddress.Parse(str));

                        }

                        client.Send(mime);
                        Thread.Sleep(1000);

                       
                        int a = LstMail.Items.Count;

                        int b = a * (int)numericUpDown1.Value; 

                        LblCount.Text = b.ToString();

                    }

                    client.Disconnect(true);


                }
            }
            catch (Exception exxi)
            {
                MessageBox.Show(exxi.Message);
            }


        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LstMail.Items.Clear();
            LblCount.Text = b.ToString();
            
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


        private void BtnStop_Click(object sender, EventArgs e)
        {
            client.Dispose();
            BtnSend.Enabled = true;
            pictureBox1.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            LblCount.Text = b.ToString();
        }

    }
}
