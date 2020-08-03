using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Models.Interfaces
{
    public interface IProgressbarService
    {
        void ShowProgressBar(string message,double value);

        void ResetProgressBar();

        void PushProgress(double value);

    }
}
