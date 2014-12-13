using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertService.Shared
{
    public interface IAlertService
    {
        Task ShowAlertAsync(string title, string content, params CallbackDelegate[] delegates);

        Task ShowAlertAsync(string title, object content, params CallbackDelegate[] delegates);
    }

    public class CallbackDelegate
    {
        public string Name {get; private set;}

        public Func<Task> Delegate {get; private set;}
    }
}
