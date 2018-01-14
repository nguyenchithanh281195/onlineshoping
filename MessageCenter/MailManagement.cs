using System;
using System.Net.Mail;

namespace MessageCenter
{
    public class MailManagement
    {
        private static string sender = "ktpm2018@gmail.com"; //email, password of sender
        private static string password = "KTPM@)!*";

        public MailManagement()
        {
        }

        public static bool SendMail(string recipient, string subject, string body){
            try {
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                SmtpServer.Port = 587;
                SmtpServer.EnableSsl = true;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(sender, password);

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(sender);
                mail.To.Add(recipient); 
                mail.Subject = subject; 
                mail.Body = body;
                SmtpServer.Send(mail);
                return true;
            }
            catch{
                return false;
            }
           
        }
    }
}
