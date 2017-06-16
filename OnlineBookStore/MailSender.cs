using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace OnlineBookStore
{
    static class MailSender
    {
        static public void Send(string attachment)
        {
            string YourMailAddress = "Please write here your outlook mail address.";
            string YourPassword = "Please write here your password";
            Customer customer = Customer.getInstance();
            MailMessage message = null;
            if(YourMailAddress.Contains(" ") || YourPassword.Contains(" ")) { 
                MessageBox.Show("Inorder to use this function you must configure MailSender class.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                message = new MailMessage(YourMailAddress, customer.Email, "Shopping Invoice", "Hi " + customer.Name + ". Thanks for your purchase. Here is your bill.");
                message.IsBodyHtml = false;
                SmtpClient client = new SmtpClient("smtp.outlook.com", 587);
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(YourMailAddress, YourPassword);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                message.Attachments.Add(new Attachment(attachment));
                client.Send(message);
                MessageBox.Show("Email has been sent. Please check your inbox and spam.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email sending failed. Please contact administrators.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
