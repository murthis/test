using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class WaterIntake
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Glasses Consumed")]
        public double numberOfGlassesConsumed  { get; set; }

        [Display(Name = "Target Glasses")]
        [Required]
        public double targetGlasses { get; set; }

        public double remainingGlasses { get { return ((numberOfGlassesConsumed / targetGlasses)*100); } }
    }
}