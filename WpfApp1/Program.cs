using System;
using System.Threading;
using System.Threading.Tasks;

namespace WpfApp1
{
    static class Program
    {
        static void Main()
        {
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
