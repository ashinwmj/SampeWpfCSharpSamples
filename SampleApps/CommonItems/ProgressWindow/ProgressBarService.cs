using System;
using System.Windows.Threading;
using Application.Interfaces.Models.Interfaces;

namespace CommonItems.ProgressWindow
{
   public class ProgressBarService: IProgressbarService
   {
       private ProgressWindow pbWindow;
       private Dispatcher dispatcher;
       public void ShowProgressBar(string message, double value)
       {
           if (pbWindow == null)
           {
               pbWindow=new ProgressWindow();
               dispatcher = Dispatcher.CurrentDispatcher;
           }

           if (!pbWindow.IsActive)
           {
               pbWindow.Show();
           }

           dispatcher.Invoke(new Action(() =>
           {
               pbWindow.setText.Text = message;
               if (value > 250)
               {
                   value = 100;
               }

               var pbValue = (value * 250) / 100;
               pbWindow.slideBar.Width = Convert.ToDouble(pbValue);
           }));
       }

        public void ResetProgressBar()
       {
           pbWindow?.Close();
           pbWindow = null;
       }

       public void PushProgress(double value)
       {
         
       }
   }
}
