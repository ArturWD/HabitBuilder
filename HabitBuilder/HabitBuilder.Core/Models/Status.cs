using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder.Core.Models
{
    [Table("Statuses")]
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
