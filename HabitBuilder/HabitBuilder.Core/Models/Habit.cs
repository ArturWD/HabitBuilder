using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder.Core.Models
{
    [Table("Habits")]
    public class Habit
    {
        public int HabitId { get; set; }
        public string HabitName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Reason> Reasons { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Day> Days { get; set; }
        public virtual ICollection<DayStatus> DayStatuses { get; set; }

    }
}
