using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Persistence.Entities.Configuration;


namespace DB.Persistence.Context
{
    public partial class BoletoContext
    {
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Asiento> Asientos { get; set; }
    }
}
