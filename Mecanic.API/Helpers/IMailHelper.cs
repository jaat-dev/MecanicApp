using Mecanic.Common.Models;

namespace Mecanic.API.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string to, string subject, string body);
    }
}
