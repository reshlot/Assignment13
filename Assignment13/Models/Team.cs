using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment13.Models
{
    [Table("Team")]
    public class Team
    {
            [Key]
            public int TeamId { get; set; }
            [Required]
            [StringLength(50)]
            public string TeamName { get; set; }
            [Required]
            public int NOWC { get; set; }
        
    }
}
