using Spire.Email;
using Spire.Email.IMap;
using Spire.Email.Pop3;
using Spire.Email.Smtp;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Maily
{
    public partial class MailyForm : Form
    {
        MailAddress addressFrom;
        MailAddress addressTo;
        MailMessage message;
        SmtpClient smtp = new SmtpClient();

        string userAddress;
        string userPassword;

        Pop3Client pop = new Pop3Client();

        public MailyForm()
        {
            InitializeComponent();

            tabs.TabPages.Remove(sendForm);
            tabs.TabPages.Remove(inboxForm);

            loginButton.Visible = true;
            logOutButton.Visible = false;

            passwordBox.PasswordChar = '*';
            lettersView.View = View.Details;
            lettersView.Scrollable = true;

            addColumnToListView();

            letterContent.WordWrap = true;
            letterContent.Multiline = true;
            letterContent.ScrollBars = ScrollBars.Vertical;
            letterContent.ReadOnly = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if ((usernameBox.Text == "" || passwordBox.Text == "") || !IsValidEmail(usernameBox.Text))
            {
                statusLabel.Text = "Error! Check your fields!";
                return;
            }

            tabs.TabPages.Add(sendForm);
            tabs.TabPages.Add(inboxForm);
            userAddress = usernameBox.Text;
            userPassword = passwordBox.Text;
            loginButton.Visible = false;
            logOutButton.Visible = true;
            statusLabel.Text = "";
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if ((usernameBox.Text == "" || passwordBox.Text == "" || portBox.Text == "" || hostBox.Text == "" || toBox.Text == "") || !IsValidEmail(usernameBox.Text))
            {
                statusLabel.Text = "Error! Check your fields!";
                return;
            }
            
            try
            {
                addressFrom = usernameBox.Text;
                addressTo = toBox.Text;
                message = new MailMessage(addressFrom, addressTo);
                message.Subject = subjectBox.Text;
                message.BodyText = messageBox.Text;

                smtp.Host = hostBox.Text;
                smtp.ConnectionProtocols = ConnectionProtocols.Ssl;
                smtp.Username = addressFrom.Address;
                smtp.Password = passwordBox.Text;

                smtp.Port = int.Parse(portBox.Text);
                smtp.SendOne(message);

                statusLabel.Text = "Successfully sent!";
            } catch(Exception err)
            {
                statusLabel.Text = "Fail! Check your fields";
                Console.WriteLine(err);
            }
        }

        private void getMailButton_Click(object sender, EventArgs e)
        {
            if ((usernameBox.Text == "" || passwordBox.Text == "") || !IsValidEmail(usernameBox.Text))
            {
                statusLabel.Text = "Error! Check your fields!";
                return;
            }

            pop.Host = hostBox.Text;
            pop.Username = userAddress;
            pop.Password = userPassword;
            pop.Port = 995;
            pop.EnableSsl = true;
            try
            {
               
                pop.Connect();

                int count = pop.GetMessageCount();

                if (count == 0)
                {
                    return;
                }

                Console.WriteLine("------------------------------" + count);
                for (int i = 1; i < count; i++)
                {
                    MailMessage message = pop.GetMessage(i);

                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = message.Subject;
                    lettersView.Items.Add(lvi);
                }

                /*
                if(lettersView.Items.Count == 0) { 
                    getMailButton.Visible = false;
                }*/
            }
            catch (Exception err)
            {
                statusLabel.Text = "Fail! Check your fields";
                Console.WriteLine(err);
            }

           
        }

        private void lettersView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lettersView.SelectedItems.Count == 0))
                return;

            int index = lettersView.SelectedItems[0].Index + 1;
            MailMessage message = pop.GetMessage(index);
            letterContent.Text = "------------------------------HEADERS------------------------------\r\n" +
                "From: " + message.From.ToString() + "\r\n" +
                "To: " + message.To.ToString() + "\r\n" +
                "Date: " + message.Date.ToString(CultureInfo.InvariantCulture) + "\r\n" +
                "Subject: " + message.Subject + "\r\n" +
                "-------------------------------BODY-------------------------------" + "\r\n" +
                message.BodyText + "\r\n" +
                "-------------------------------END-------------------------------";
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            if (loginButton.Visible == false)
            {
                tabs.TabPages.Remove(sendForm);
                tabs.TabPages.Remove(inboxForm);
                statusLabel.Text = "";
                loginButton.Visible = true;
                logOutButton.Visible = false;
                usernameBox.Text = "";
                passwordBox.Text = "";
                lettersView.Clear();
                addColumnToListView(); 
                getMailButton.Visible = true;

                pop.Disconnect();
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void addColumnToListView()
        {
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            header.Width = lettersView.Width;
            lettersView.Columns.Add(header);
            letterContent.Text = "";
          
            
        }

    }
}
