using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Persistence.Base;

namespace DB.Persistence.Entities.Configuration
{
    [Table("Asiento")]
    public sealed class Asiento : AuditEntity<int>
    {
        [Key]
        [Column("IdAsiento")]
        public override int Id { get; set; }

        public int IdBus { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
    }
}
