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
        readonly MimeMessage mime = new MimeMessage();
        readonly BodyBuilder builder = new BodyBuilder();
        int count;
        private void BtnFile_Click(object sender, EventArgs e)
        { //Button File and creation of FileDialog, reading the stream and adding to ListTextBox
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Multiselect = false,
                    Filter = "TEXT Files(*.txt)|*.txt|CSV Files(*.csv)|*.csv"
                };

                DialogResult dial = ofd.ShowDialog();

                if (dial == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(@ofd.FileName);
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        LstMail.Items.Add(line);
                    }

                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnSend_Click(object sender, EventArgs e)
        {//Implementation of the backgroundWorker for multithread management

            BtnSend.Enabled = false;
            pictureBox1.Enabled = true;
            backgroundWorker1.RunWorkerAsync();
        }
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BtnSend.Enabled = true;
            pictureBox1.Enabled = false;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs ea)
        {
            CheckForIllegalCrossThreadCalls = false;

            //Sending method, creation of SMTP, body, management of the font and message builder
            try
            {
                RtfPipe.Rtf.ToHtml(RichTextBox1.Rtf);
                SmtpClient client = new SmtpClient
                {
                    Timeout = 3000
                };

                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect(TxtHost.Text, int.Parse(TxtPort.Text), MailKit.Security.SecureSocketOptions.StartTlsWhenAvailable);
                client.Authenticate(TxtUser.Text, TxtPass.Text);
               
                
                for (int i = 0; i < (int)numericUpDown1.Value; i++)
                {
                    mime.From.Add(new MailboxAddress(TxtName.Text, TxtUser.Text));
                    mime.Subject = TxtSbj.Text;
                    builder.HtmlBody = RtfPipe.Rtf.ToHtml(RichTextBox1.Rtf);

                    if (CheckHtml.Checked == true)
                    {
                        builder.HtmlBody = RichTextBox1.Text;
                    }

                    if (TxtFile.Text != string.Empty)
                    {
                        builder.Attachments.Add(@fl.FileName);
                        mime.Body = builder.ToMessageBody();
                    }
                    else
                    {
                        mime.Body = builder.ToMessageBody();
                    }


                    if (LstMail.Items.Count > 0)
                    {
                        foreach (string str in LstMail.Items)
                        {
                            mime.To.Add(MailboxAddress.Parse(str));
                        }

                        client.Send(mime);
                        Thread.Sleep(1000);

                        count++;
                        int a = LstMail.Items.Count;
                        int b = a * count;
                        LblCount.Text = b.ToString();
                        BtnSend.Enabled = true;
                    }
                    else
                    {
                        mime.To.Add(MailboxAddress.Parse(TxtTo.Text));
                        client.Send(mime);
                        Thread.Sleep(1000);
                        count++;
                        LblCount.Text = count.ToString();
                        pictureBox1.Enabled = false;
                        BtnSend.Enabled = true;
                    }

                }
                MessageBox.Show("WORK DONE!!!", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Enabled = false;
                client.Disconnect(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pictureBox1.Enabled = false;
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {//Adding the FontFamily

            foreach (FontFamily ff in FontFamily.Families)
            {
                CmbStyle.Items.Add(ff.Name.ToString());
            }
        }
        private void CmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {//New Font selected

            RichTextBox1.Font = new Font(CmbStyle.Text, RichTextBox1.Font.Size);
        }
        private void CmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {//New Size selected

            RichTextBox1.Font = new Font(RichTextBox1.Font.FontFamily, float.Parse(CmbSize.SelectedItem.ToString()));
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {//Bold

            FontStyle noBold;

            if (RichTextBox1.SelectionFont.Bold == true)
                noBold = FontStyle.Regular;
            else
                noBold = FontStyle.Bold;

            RichTextBox1.SelectionFont = new Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, noBold);
        }

        private void BtnStrike_Click(object sender, EventArgs e)
        {//Strike

            FontStyle noStrike;

            if (RichTextBox1.SelectionFont.Strikeout == true)
                noStrike = FontStyle.Regular;
            else
                noStrike = FontStyle.Strikeout;

            RichTextBox1.SelectionFont = new Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, noStrike);
        }

        private void BtnItalic_Click(object sender, EventArgs e)
        {//Italic

            FontStyle noItalic;

            if (RichTextBox1.SelectionFont.Italic == true)
                noItalic = FontStyle.Regular;
            else
                noItalic = FontStyle.Italic;

            RichTextBox1.SelectionFont = new Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, noItalic);
        }

        private void BtnUnder_Click(object sender, EventArgs e)
        {//Under

            FontStyle noUnder;

            if (RichTextBox1.SelectionFont.Underline == true)
                noUnder = FontStyle.Regular;
            else
                noUnder = FontStyle.Underline;

            RichTextBox1.SelectionFont = new Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, noUnder);
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {//Stop sending

            client.Dispose();
            BtnSend.Enabled = true;
            pictureBox1.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {//Reset

            count = 0;
            LblCount.Text = count.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {//Clear

            LstMail.Items.Clear();
            TxtTo.Clear();
            count = 0;
            LblCount.Text = count.ToString();
        }

        readonly OpenFileDialog fl = new OpenFileDialog();

        private void BtnAttach_Click(object sender, EventArgs e)
        {//Attachment

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
        {//Clear SMTP values

            TxtHost.Clear();
            TxtUser.Clear();
            TxtName.Clear();
            TxtPass.Clear();
            TxtPort.Clear();
            numericUpDown1.Value = 1;
        }

        private void CheckSsl_CheckedChanged(object sender, EventArgs e)
        {//SSL protocol

            SmtpClient client1 = new SmtpClient();
            if (CheckSsl.Checked)
                client1.SslProtocols = System.Security.Authentication.SslProtocols.Default;
            
        }

        private void BtnClr_Click(object sender, EventArgs e)
        {//Change the color

            ColorDialog color = new ColorDialog();
            DialogResult dr = color.ShowDialog();

            if (dr == DialogResult.OK)
                RichTextBox1.SelectionColor = color.Color;
        }

        private void BtnClf_Click(object sender, EventArgs e)
        {//Clear attachment

            TxtFile.Clear();
        }
        private void BtnLeft_Click(object sender, EventArgs e)
        {
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void BtnCenter_Click(object sender, EventArgs e)
        {
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        
        private void CheckEncode_CheckedChanged(object sender, EventArgs e)
        {//Replace spaces and characters with unicode characters for RichTextBox

            if (CheckHtml.Checked == true)
                RichTextBox1.Text = RichTextBox1.Text.Replace(",", "&#8218;");

            if (CheckEncode.Checked == false)
                RichTextBox1.Text = RichTextBox1.Text.Replace("&#8218;", ",");
            

            if (CheckHtml.Checked == false)
                RichTextBox1.Text = RichTextBox1.Text.Replace(",", "\u201A");
                RichTextBox1.Text = RichTextBox1.Text.Replace(" ", "\u00A0");

            if(CheckEncode.Checked == false)
                RichTextBox1.Text = RichTextBox1.Text.Replace("\u201A", ",");
                RichTextBox1.Text = RichTextBox1.Text.Replace("\u00A0", " ");
        }
    }
}




