﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder.Core.Models
{
    [Table("Reasons")]
    public class Reason
    {
        public int ReasonId { get; set; }
        public string ReasonText { get; set; }

    }
}
