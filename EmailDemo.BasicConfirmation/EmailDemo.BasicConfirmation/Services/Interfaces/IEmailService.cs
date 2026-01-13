namespace EmailDemo.BasicConfirmation.Services.Interfaces
{
    public interface IEmailService
    {
        void SendWelcomeEmail(string userName, string userEmail);
    }
}