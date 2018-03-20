using System.Threading.Tasks;

namespace CinemaBookingData
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}