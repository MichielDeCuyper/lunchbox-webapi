using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.Models
{
    public class Recipe : Entity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Url]
        [MaxLength(125)]
        public string PhotoURL { get; set; }

        [Required]
        [MaxLength(2500)]
        public string Description { get; set; }
    }
}