using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Models.Interfaces
{
  public  interface IProjectWebApi
  {
    Task<IList<ProjectInfo>> GetProjectNames();

    void SetProjectName(string proName);
  }
}
