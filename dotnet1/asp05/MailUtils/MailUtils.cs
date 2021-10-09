using System.Net.Mail;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Net;

namespace asp05{
    public class MailUtils{
        public static async Task<string> SendMail(string from, string to, string subject, string body)
        {
            MailMessage message=new MailMessage(from, to, subject, body);
            message.BodyEncoding=Encoding.Unicode;
            message.SubjectEncoding=Encoding.Unicode;
            message.IsBodyHtml=true;
            message.ReplyToList.Add(new MailAddress(from));
            message.Sender=new MailAddress(from);

            using var smtpClient=new SmtpClient("localhost");
            
            try{
                await smtpClient.SendMailAsync(message);
                return "send successed";
                
            }catch(Exception e){
                Console.Write(e.Message);
                return "send no successed";
            }
        }
        public static async Task<string> SendGmail(string from, string to, string subject, string body, string _gmail, string _password)
        {
            MailMessage message=new MailMessage(from, to, subject, body);
            message.BodyEncoding=Encoding.Unicode;
            message.SubjectEncoding=Encoding.Unicode;
            message.IsBodyHtml=true;
            message.ReplyToList.Add(new MailAddress(from));
            message.Sender=new MailAddress(from);

            using var smtpClient=new SmtpClient("smtp.gmail.com");
            smtpClient.Port=587;
            smtpClient.EnableSsl=true;
            smtpClient.Credentials=new NetworkCredential(_gmail, _password);
            
            try{
                await smtpClient.SendMailAsync(message);
                return "send successed";
                
            }catch(Exception e){
                Console.Write(e.Message);
                return "send no successed";
            }
        }
    }
}