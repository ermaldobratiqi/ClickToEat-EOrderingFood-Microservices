using ClickToEat.Services.Email.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClickToEat.Services.Email.Repository
{
    public interface IEmailRepository
    {
        Task SendAndLogEmail(UpdatePaymentResultMessage message);
    }
}
