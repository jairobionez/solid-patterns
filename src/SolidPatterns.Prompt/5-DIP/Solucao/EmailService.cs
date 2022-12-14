using SolidPatterns.Prompt.DIP.Solucao.Interfaces;
using System.Net.Mail;

namespace SolidPatterns.Prompt.DIP.Solucao
{
    public class EmailService : IEmailService
    {
        public void Enviar(string de, string para, string assunto, string mensagem)
        {
            var mail = new MailMessage(de, para);
            var client = new SmtpClient()
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smpt.google.com"
            };

            mail.Subject = assunto;
            mail.Body = mensagem;
            client.Send(mail);
        }
    }
}
