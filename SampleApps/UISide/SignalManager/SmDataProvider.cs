using System;
using System.Threading;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using Application.Interfaces.Models.Interfaces;
using Microsoft.Practices.Unity;
using Container = UnityContainer.Container;

namespace UISide.SignalManager
{
    public class SmDataProvider:ISmDataProvider
    {
        private ISignalService _signalService;
        private IProgressbarService _pbService;
        public  SmDataProvider()
        {
          _signalService=  Container.Instance.GetUnityContainer().Resolve<ISignalService>("ownservice");
          _pbService = Container.Instance.GetUnityContainer().Resolve<IProgressbarService>();
        }
        public async Task<DataTable> GetData()
        {
  
            _pbService.ShowProgressBar("Fetching Signals from Db.....",0);
            var signals = await _signalService.GetAllSignals();
            _pbService.ShowProgressBar("Preparing Signals....", 50);
            await Task.Delay(2000);
            double signalCount = signals.Count;
            var datatable=new DataTable();
            var colCollection = datatable.Columns;
            colCollection.Add(new DataColumn("SIG_NAME"));
            colCollection.Add(new DataColumn("TAG_SOURCE"));
            double Counter = 0;
            foreach (var signal in signals)
            {
                Counter++;
                double percent = (Counter / signalCount)*100;
                var dataRow = datatable.NewRow();
                dataRow["SIG_NAME"] = signal.Name;
                dataRow["TAG_SOURCE"] = signal.TagSource;
                foreach (var attribute in signal?.Attributes)
                {
                    if (!colCollection.Contains(attribute.Key))
                    {
                        colCollection.Add(new DataColumn(attribute.Key));
                    }
                    dataRow[attribute.Key] = attribute.Value;
                }
                datatable.Rows.Add(dataRow);
                _pbService.ShowProgressBar("Iterating....",percent);
            }

            await Task.Delay(500);
            _pbService.ShowProgressBar("Completed",100);
            _pbService.ResetProgressBar();
            return datatable;
        }
    }

    public interface ISmDataProvider
    {
        Task<DataTable> GetData();
    }
}
