using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TShopper.Worker
{
    public interface INotification
    {
        #region Gửi thông báo nhắc nhở
        Task SendSMSRemind();
        Task SendMailRemind();
        Task SendNotifyRemind();
        #endregion

        #region Gửi thông báo hết hạn
        Task SendSMSExpired();
        Task SendMailExpired();
        Task SendNotifyExpired();
        #endregion
    }
    public class Notification : INotification
    {
        private readonly ILogger<Notification> _logger;

        public Notification(ILogger<Notification> logger)
        {
            _logger = logger;
        }

        public async Task SendMailExpired()
        {
            Console.WriteLine("xxxxxxxxxxxxxxxxx");
        }

        public async Task SendMailRemind()
        {
            throw new NotImplementedException();
        }

        public async Task SendNotifyExpired()
        {
            throw new NotImplementedException();
        }

        public async Task SendNotifyRemind()
        {
            throw new NotImplementedException();
        }

        public async Task SendSMSExpired()
        {
            throw new NotImplementedException();
        }

        public async Task SendSMSRemind()
        {
            throw new NotImplementedException();
        }
    }
}
