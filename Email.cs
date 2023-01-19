using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Astect
{
    class Email
    {
        List<String> codeList;

        public Email()
        {
            codeList = new List<String>();
        }
        public void sendPasswordResetCode(string email)
        {
            string fromMail = "astectscrum3@gmail.com";
            string fromPassword = "mpwpasuygrsxatqr";
            string code = getRandomResetCode();

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Astect - Password Recovery";
            message.To.Add(new MailAddress(email));
            message.Body = "<html><body> Here is your recovery code. <br> Please enter this code in the application to reset your password. <br> "+code+" </body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            codeList.Add(code);
            smtpClient.Send(message);
        }

        private string getRandomResetCode()
        {
            Random random = new Random();
            string code = Convert.ToString(random.Next());
            return code;
        }

        public bool isPasswordResetCodeValid(string code)
        {
            bool isCodeValid = false;

            if (codeList.Contains(code))
            {
                isCodeValid = true;
            }

            return isCodeValid;
        }
    }
}
