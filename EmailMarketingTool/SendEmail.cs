using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailMarketingTool
{
    class SendEmail
    {
        public static void SendEmailMarketing(string toAddress,string fromAddress,string pass,string subject,string content ) 
        {
            using (MailMessage mail = new MailMessage())
            {
                //initialize info
                mail.From = new MailAddress(fromAddress);
                mail.To.Add(toAddress);
                mail.Subject = subject;
                mail.Body = content;
                mail.IsBodyHtml = true;


                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    //
                    smtp.Credentials = new NetworkCredential(fromAddress, pass);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}
