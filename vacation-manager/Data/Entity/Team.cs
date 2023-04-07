using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required, NotNull]
        public string Name { get; set; }

        public ICollection<User> Developers { get; set; }

        public User Leader { get; set; }
    }
}
