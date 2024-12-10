using DB.Persistence.Entities.Configuration;
using DB.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Persistence.Interfaces
{
    public interface IBusRepository : IBaseRepository<Bus, int, BusModel>
    {

    }
}
