using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamId { get; set; }

        [Required, NotNull]
        public string Name { get; set; }

        [Required, NotNull]
        public virtual ICollection<User> Users { get; set; }

        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        [Required, NotNull]
        public virtual Project Project { get; set; }
    }
}
