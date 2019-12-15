using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingWebAPI.Models
{
    public class Training
    {
        [Key]
        public int TrainingId { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string TrainingName { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
    }
}
