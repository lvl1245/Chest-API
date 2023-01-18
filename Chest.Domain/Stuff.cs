using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Chest.Domain
{
    public class Stuff
    {
        [Required]
        public double Size { get; set; }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Key]
        [ForeignKey("Chest")]
        public int? ChestId { get; set; }

        public virtual Chest Chest { get; set; }
    }
}
