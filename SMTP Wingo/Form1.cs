using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Sockets;

namespace SMTP_Wingo
{
    public partial class Form1 : Form
    {
        int[] PortArr = new int[6] { 25, 26, 465, 587, 2525, 3535 };

        public Form1()
        {
            InitializeComponent();
        }

        public bool Pop_Socket_Lock_It(String host, int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Connect using a timeout (5 seconds)

            IAsyncResult result = socket.BeginConnect(host, port, null, null);

            bool success = result.AsyncWaitHandle.WaitOne(5000, true);//Timeout is 5 secs

            if (!success)
            {
                // NOTE, MUST CLOSE THE SOCKET

                socket.Close();
                return false;
                //throw new ApplicationException("Failed to connect server.");
            }
            socket.Close();
            return true;
        }

        private void AddButt_Click(object sender, EventArgs e)
        {
            if (ServerNameTB.Text != "")
            {
                ServerList.Items.Add(ServerNameTB.Text);
                ServerNameTB.Text = "";
            }
        }

        private void DelButt_Click(object sender, EventArgs e)
        {
            ServerList.Items.RemoveAt(ServerList.SelectedIndex);
        }

        private void PortCycle()
        {
            if (ServerList.Text != "")
            {
                //"smtp.gmail.com"
                for (int x = 0; x < 6; x++)
                {
                    SmtpClient client = new SmtpClient(ServerList.Text, PortArr[x]);

                    if (PortArr[x] == 587 || PortArr[x] == 26 || PortArr[x] == 465)
                        client.EnableSsl = true;
                    else
                        client.EnableSsl = false;

                    MailAddress from = new MailAddress(SenderEmail.Text, "Bug Bounty Test");

                    MailAddress to = new MailAddress(ReceiverEmail.Text, "Bug Bounty Tester");

                    MailMessage message = new MailMessage(from, to);

                    message.Body = "This is a test for your bug bounty program";

                    message.Subject = "Bug Bounty Test";

                    //UseDefaultCredentials=true;

                    //client.UseDefaultCredentials=true;
                    client.Timeout = 5000;

                    try
                    {

                        client.Send(message);
                        PassedTextBox.AppendText(ServerList.Text + " Port: " + PortArr[x] + " PASSED" + Environment.NewLine);
                        this.ProgBar.Increment(17);
                    }

                    catch (Exception ex)
                    {
                        //TextBox.AppendText("Exception is:" + ex.ToString());
                        TextBox.AppendText(ServerList.Text + " Port: " + PortArr[x] + " FAILED" + Environment.NewLine);
                        this.ProgBar.Increment(17);
                    }
                }
            }
        }

        private void ServerCycle()
        {
            foreach (string s in ServerList.Items)
            {
                SmtpClient client = new SmtpClient(s, Convert.ToInt32(PortTextBox.Text));

                if (PortTextBox.Text == "587" || PortTextBox.Text == "26" || PortTextBox.Text == "465")
                    client.EnableSsl = true;
                else
                    client.EnableSsl = false;

                MailAddress from = new MailAddress(SenderEmail.Text, "Bug Bounty Test");

                MailAddress to = new MailAddress(ReceiverEmail.Text, "Bug Bounty Tester");

                MailMessage message = new MailMessage(from, to);

                message.Body = "This is a test for your bug bounty program";

                message.Subject = "Bug Bounty Test";

                //UseDefaultCredentials=true;

                //client.UseDefaultCredentials=true;
                client.Timeout = 5000;

                try
                {

                    client.Send(message);
                    PassedTextBox.AppendText(s + " Port: " + PortTextBox.Text + " PASSED" + Environment.NewLine);
                    this.ProgBar.Increment(100 / ServerList.Items.Count);
                }

                catch (Exception ex)
                {
                    TextBox.AppendText(s + " Port: " + PortTextBox.Text + " FAILED" + Environment.NewLine);
                    this.ProgBar.Increment(100/ServerList.Items.Count);
                }
            }
        }

        private void Server_Port_Cycle()
        {
            for (int x = 0; x < 6; x++)
            {
                foreach (string s in ServerList.Items)
                {
                    SmtpClient client = new SmtpClient(ServerList.Text, PortArr[x]);

                    if (PortArr[x] == 587 || PortArr[x] == 26 || PortArr[x] == 465)
                        client.EnableSsl = true;
                    else
                        client.EnableSsl = false;

                    MailAddress from = new MailAddress(SenderEmail.Text, "Bug Bounty Test");

                    MailAddress to = new MailAddress(ReceiverEmail.Text, "Bug Bounty Tester");

                    MailMessage message = new MailMessage(from, to);

                    message.Body = "This is a test for your bug bounty program";

                    message.Subject = "Bug Bounty Test";

                    //UseDefaultCredentials=true;

                    //client.UseDefaultCredentials=true;
                    client.Timeout = 5000;

                    try
                    {

                        client.Send(message);
                        PassedTextBox.AppendText(s + " Port: " + PortArr[x] + " PASSED" + Environment.NewLine);
                        this.ProgBar.Increment(100 / (ServerList.Items.Count * 6));
                    }

                    catch (Exception ex)
                    {
                        //TextBox.AppendText("Exception is:" + ex.ToString());
                        TextBox.AppendText(s + " Port: " + PortArr[x] + " FAILED" + Environment.NewLine);
                        this.ProgBar.Increment(100 /(ServerList.Items.Count*6));
                    }
                }
            }       
        }

        private void Start()
        {
            if (SenderEmail.Text != "" && ReceiverEmail.Text != "")
            {
                if (PortCycleCB.Checked.Equals(true) && checkBoxServer.Checked.Equals(false))
                {
                    StartButt.Enabled = false;
                    PortCycle();
                    StartButt.Enabled = true;
                }
                else if (PortCycleCB.Checked.Equals(false) && checkBoxServer.Checked.Equals(true))
                {
                    StartButt.Enabled = false;
                    ServerCycle();
                    StartButt.Enabled = true;
                }
                else if (PortCycleCB.Checked.Equals(true) && checkBoxServer.Checked.Equals(true))
                {
                    StartButt.Enabled = false;
                    ServerCycle();
                    StartButt.Enabled = true;
                }
                else
                {
                    SmtpClient client = new SmtpClient(ServerList.Text, Convert.ToInt32(PortTextBox.Text));

                    if (PortTextBox.Text == "587" || PortTextBox.Text == "26" || PortTextBox.Text == "465")
                        client.EnableSsl = true;
                    else
                        client.EnableSsl = false;

                    MailAddress from = new MailAddress(SenderEmail.Text, "Bug Bounty Test");

                    MailAddress to = new MailAddress(ReceiverEmail.Text, "Bug Bounty Tester");

                    MailMessage message = new MailMessage(from, to);

                    message.Body = "This is a test for your bug bounty program";

                    message.Subject = "Bug Bounty Test";

                    //UseDefaultCredentials=true;

                    //client.UseDefaultCredentials=true;
                    client.Timeout = 5000;

                    try
                    {

                        client.Send(message);
                        PassedTextBox.AppendText(ServerList.Text + " Port: " + PortTextBox.Text + " PASSED" + Environment.NewLine);
                        this.ProgBar.Increment(100);
                    }

                    catch (Exception ex)
                    {
                        TextBox.AppendText(ServerList.Text + " Port: " + PortTextBox.Text + " FAILED" + Environment.NewLine);
                        this.ProgBar.Increment(100);
                    }
                }
            }       
        }

        private void StartButt_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SenderEmail.Text = "bug_bounty_test@bbtest.com";
            PortTextBox.Text = "587";//25 587 
        }

        private void portCycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("These are the ports that are cycled.\n25-Default\n26-Encrypted SMTP - Sent over SSL\n465-SMTPS - Sent over SSL\n587-MSA- Sent over SSL\n2525-SMTP Alternate\n3535-SMTP Alternate");
            /*587, 26, 465
            Port
            25 - Default
            26 - Encrypted SMTP
            465 - SMTP over TLS/SSL (SMTPS)
            587 - MSA
            2525 - SMTP alternate
            3535 - SMTP alternate
            */
        }

        private void LogsButt_Click(object sender, EventArgs e)
        {
            PassedTextBox.Text = "";
            TextBox.Text = "";

        }

        private void abountWingoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("SMTP is a 2 hr program that was created on opiates.\nWhy does it take so long?\nThe TCP timeout is set to the default lengh ~30secs.\nThe SMTP timeout is trimmed down a bit.\nIf you get pissed about the time, just use a port scanner.");
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start();
        }
    }
}
