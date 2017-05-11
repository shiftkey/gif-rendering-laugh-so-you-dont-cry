using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var animatedGifWindowToken = new CancellationTokenSource();

            var progressSource = new ProgressSource();
            
            AnimatedGifWindow.ShowWindow(TimeSpan.FromSeconds(1), animatedGifWindowToken.Token, progressSource);

            Task.Delay(TimeSpan.FromMinutes(5)).Wait();
            
            animatedGifWindowToken.Cancel();
        }
    }


    public class ProgressSource
    {
        public event EventHandler<int> Progress;

        public void Raise(int i)
        {
            if (Progress != null)
                Progress.Invoke(this, i);
        }
    }
}


