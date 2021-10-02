using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TShopper.Worker
{
    public class WorkerService : BackgroundService
    {
        private Task _excuteTask;
        private CancellationTokenSource _cts; //Class này cung cấp cách để hủy một Task đang run 
        private readonly ILogger<WorkerService> _logger;
        private readonly IServiceProvider _serviceProvider;

        public WorkerService(ILogger<WorkerService> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Notification service is running...");
            _cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);

            var _excuteTask = ExecuteAsync(_cts.Token);

            return _excuteTask.IsCompleted ? _excuteTask : Task.CompletedTask;
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            if (_excuteTask == null)
                return;

            _cts.Cancel();

            await Task.WhenAny(_excuteTask, Task.Delay(-1, cancellationToken));
            cancellationToken.ThrowIfCancellationRequested();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await DoWork();
                await Task.Delay(1000, stoppingToken);
            }
        }

        private async Task DoWork()
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var notification = scope.ServiceProvider.GetRequiredService<INotification>();

                #region Gửi thông báo nhắc nhở
                notification.SendSMSRemind();
                notification.SendMailRemind();
                notification.SendNotifyRemind();
                #endregion

                #region Gửi thông báo hết hạn
                notification.SendSMSExpired();
                notification.SendMailExpired();
                notification.SendNotifyExpired();
                #endregion
            }
        }

    }
}
