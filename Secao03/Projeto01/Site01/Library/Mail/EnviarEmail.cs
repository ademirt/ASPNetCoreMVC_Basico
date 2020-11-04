using Site01.Models;
using System.Net;
using System.Net.Mail;

namespace Site01.Library.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagemContato(Contato contato)
        {
            string conteudo = string.Format("NOME: {0}, EMAIL: {1}, ASSUNTO: {2} , MENSAGEM: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
            
            //configurar servidor SMTP
            SmtpClient smtp = new SmtpClient(Constants.ServSMTP, Constants.PortSMTP);
            smtp.EnableSsl = true;            
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);

            //mensagem email
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("ademir.tafner@hotmail.com");
            mensagem.To.Add("ademir.tafner@hotmail.com");
            mensagem.Subject = "Formulário de contato";

            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulário de conato </h1>" + conteudo;

            smtp.Send(mensagem);

        }
    }
}
