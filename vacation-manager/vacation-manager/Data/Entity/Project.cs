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
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        [Required, NotNull]
        public string Name { get; set; }

        [Required, NotNull]
        public string Description { get; set; }

        [Required, NotNull]
        public virtual ICollection<Team> Teams { get; set; }
    }
}
