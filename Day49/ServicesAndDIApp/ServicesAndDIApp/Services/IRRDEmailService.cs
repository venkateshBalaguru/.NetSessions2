    namespace ServicesAndDIApp.Services
{
    public interface IRRDEmailService
    {
        Task SendEmailAsync(string to, string subject, string body);
    }
}
