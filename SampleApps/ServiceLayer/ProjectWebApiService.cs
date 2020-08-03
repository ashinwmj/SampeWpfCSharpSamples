using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Models;
using Application.Interfaces.Models.Interfaces;

namespace ServiceLayer
{
   public class ProjectWebApiService:IProjectWebApi
    {
        public Task<IList<ProjectInfo>> GetProjectNames()
        {
            return Task.Run(() =>
            {
                IList<ProjectInfo> projectInfoList=new List<ProjectInfo>();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44345/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("projects");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<ProjectInfo[]>();
                        readTask.Wait();

                        var projectInfos = readTask.Result;
                        foreach (var info in projectInfos)
                        {
                           projectInfoList.Add(info);
                        }
                    }
                }

                return projectInfoList;
            });
        }

        public void SetProjectName(string proName)
        {
           // throw new NotImplementedException();
        }
    }
}
