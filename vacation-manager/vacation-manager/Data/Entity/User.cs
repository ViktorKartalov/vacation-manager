using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using vacation_manager.Data.Entity;

namespace Data.Entity
{
    public class User : IdentityUser
    {

        [Required, NotNull]
        public string FirstName { get; set; }

        [Required, NotNull]
        public string LastName { get; set; }


        public string RoleId { get; set; }
        [ForeignKey("RoleId")]
        [Required, NotNull]
        public virtual Role Role { get; set; }

        public int TeamId { get; set; }
        [ForeignKey("TeamId")]
        [Required, NotNull]
        public virtual Team Team { get; set; }

        public virtual ICollection<Vacation> Vacations { get; set; }

        public bool IsLeader { get; set; }
    }
}
