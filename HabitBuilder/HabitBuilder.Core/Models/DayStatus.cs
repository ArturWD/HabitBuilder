using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder.Core.Models
{
    [Table("DayStatus")]
    public class DayStatus
    {
        public int DayStatusId { get; set; }
        public virtual Status Status { get; set; }
        public string NoteHeadline { get; set; }
        public string Note { get; set; }

    }
}
