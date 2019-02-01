using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder.Core.Models
{
    [Table("Users")]
    public class User
    {
        public int UserId { get; set; }
        public virtual ICollection<Habit> Habits { get; set; }
    }
}
