using System.Net;
using System.Net.Mail;
using EmailDemo.BasicConfirmation.Services.Interfaces;

namespace EmailDemo.BasicConfirmation.Services
{
    public class EmailService : IEmailService
    {
        public readonly IConfiguration _config;
        public EmailService(IConfiguration config)
        {
            _config = config;
        }
        private string BuildWelcomeEmailBody(string userName)
        {
            return $@"
                    <h2>Hello Welcome, {userName}</h2>
                    <p>Welcome to <strong>ConvoX</strong></p>
                    <p>
                        We’re pleased to inform you that your account has been created successfully.
                        You can now explore ConvoX and start meaningful conversations and connections.
                    </p>
                    <p>
                        If you need any assistance, our support team is always here to help.
                    </p>

                    <p style='margin-top:20px;'>
                        Best regards,<br/>
                        <strong>Team ConvoX</strong>
                    </p>";
        }
        public void SendWelcomeEmail(string userName, string userEmail)
        {
            var Server = _config["EmailSettings:SmtpServer"];
            var Port = Convert.ToInt32(_config["EmailSettings:Port"]);
            var Name = _config["EmailSettings:SenderName"];
            var Email = _config["EmailSettings:SenderEmail"];
            var Password = _config["EmailSettings:Password"];

            var smtpClient = new SmtpClient(Server)
            {
                Port = Port,
                Credentials = new NetworkCredential(Email, Password),
                EnableSsl = true,
            };
            
            var mailMessage = new MailMessage()
            {
                From = new MailAddress(Email!, Name),
                Subject = "Welcome to ConvoX Dating App",
                Body = BuildWelcomeEmailBody(userName),
                IsBodyHtml = true
            };

            mailMessage.To.Add(userEmail);

            smtpClient.Send(mailMessage);
        }
    }
}