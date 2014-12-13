using AlertService.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertService.Service.WPF
{
    public class AlertService : IAlertService
    {
        public Task ShowAlertAsync(string title, string content, params CallbackDelegate[] delegates)
        {
            throw new NotImplementedException();
        }

        public Task ShowAlertAsync(string title, object content, params CallbackDelegate[] delegates)
        {
            throw new NotImplementedException();
        }
    }
}
