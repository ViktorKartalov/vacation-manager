using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, NotNull] 
        public string Username { get; set; }

        [Required, NotNull]
        public string Password { get; set; }

        [Required, NotNull]
        public string FirstName { get; set; }

        [Required, NotNull]
        public string LastName { get; set; }

        [Required, NotNull]
        public Role Role { get; set; }

        [Required, NotNull]
        public Team Team { get; set; }
    }
}
