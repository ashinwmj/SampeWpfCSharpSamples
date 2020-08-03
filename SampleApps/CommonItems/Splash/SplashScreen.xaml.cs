using System;
using System.Windows;
using System.Windows.Threading;

namespace CommonItems.Splash
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        private DispatcherTimer timer;
        public SplashScreen()
        {   
            InitializeComponent();
             timer=new DispatcherTimer();
             timer.Interval = TimeSpan.FromMilliseconds(5);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (slidePanel.Width < 850)
            {
                slidePanel.Width+=10;
                return;
            }
            slidePanel.Width = 50;
            this.Close();
            timer.Stop();
        }

        private void SplashScreen_OnClosed(object sender, EventArgs e)
        {
            //var  window=new Shell();
            //window.ShowDialog();
        }
    }
}
