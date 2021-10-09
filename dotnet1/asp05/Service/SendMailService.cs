using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Threading.Tasks;

public class SendMailService
{

    MailSetting _mailSetting { get; set; }
    public SendMailService(IOptions<MailSetting> mailSetting)
    {
        _mailSetting = mailSetting.Value;
    }
    public async Task<string> SendMail(MailContent mailContent)
    {
        Console.Write(_mailSetting.Mail+"11111");
        Console.Write(_mailSetting.DisplayName);
        var email = new MimeMessage();
        email.Sender = new MailboxAddress(_mailSetting.DisplayName, _mailSetting.Mail);
        email.From.Add(new MailboxAddress(_mailSetting.DisplayName, _mailSetting.Mail));

        email.To.Add(new MailboxAddress(mailContent.MailTo, mailContent.MailTo));
        email.Subject = mailContent.Subject;
        var builder = new BodyBuilder();
        builder.HtmlBody = mailContent.Body;
        email.Body = builder.ToMessageBody();

        using var smtp = new MailKit.Net.Smtp.SmtpClient();
        try
        {
           
            await smtp.ConnectAsync(_mailSetting.Host, _mailSetting.Port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_mailSetting.Mail, _mailSetting.Password);
            await smtp.SendAsync(email);
        }catch(Exception e)
        {
            Console.Write(e.Message);
            return "Send mail no successed";
        }

        smtp.Disconnect(true);
        return "Send mail successed";

    }

}
public class MailContent
{
    public string MailTo { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}