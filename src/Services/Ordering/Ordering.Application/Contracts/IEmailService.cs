using Ordering.Application.Models;

namespace Ordering.Application.Contracts
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
