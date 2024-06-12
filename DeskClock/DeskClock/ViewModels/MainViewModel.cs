using ReactiveUI;
using System;
using System.Threading.Tasks;

namespace DeskClock.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(1000);
                    
                    TimeNow = DateTime.Now.ToString("HH:mm:ss");
                }
            });
        }

        private string _timeNow = string.Empty;

        public string TimeNow
        {
            get => _timeNow;
            set => this.RaiseAndSetIfChanged(ref _timeNow, value);
        }
    }
}
