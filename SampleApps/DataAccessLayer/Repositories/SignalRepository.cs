using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Models;

namespace DataAccessLayer.Repositories
{
    public class SignalRepository:BaseRepository<Signal>
    {
 
        public SignalRepository() : base("tagmanagement.signals")
        {
        }
    }
}
