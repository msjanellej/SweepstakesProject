using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Sweepstakes
{
    class Email
    {
        public static void SendEmail(Contestant winner)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sweepstakes Manager", "sweepstakesManager@gmail.com"));
            message.To.Add(new MailboxAddress(winner.firstName, winner.emailAddress));
            message.Subject = "Thank you for entering";
            message.Body = new TextPart("plain") {
                Text = "Dear Contestant," +
                "Congratulations, you have won the Sweepstakes."
            };
            using (var client = new SmtpClient())
            {
                client.Connect ("smtp.gmail.com", 587, false);
                //I didn't add the authenticate because I didn't want to add my password, and I don't have another to use
                client.Send(message);
                client.Disconnect(true);

            }
        }
    }
}
