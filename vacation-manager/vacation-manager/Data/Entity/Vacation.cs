using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Entity;

namespace vacation_manager.Data.Entity
{
    public class Vacation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VacationId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public DateTime DateOfRequest { get; set; }

        [Required]
        public bool HalfDay { get; set; }

        [Required]
        public bool Approved { get; set; }

        public string RequestUserID { get; set; }
        [ForeignKey("RequestUserID")]
        public virtual User RequestUser { get; set; }
    }
}
