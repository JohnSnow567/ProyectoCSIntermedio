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
    [Table("Status")]
    public sealed class Status : BaseEntity<short>
    {
        [Key]
        [Column("StatusId")]
        public override short Id { get; set; }

        public string? Description { get; set; }
    }
}
