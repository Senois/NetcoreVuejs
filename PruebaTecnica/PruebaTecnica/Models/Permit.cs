using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class Permit
    {
        [Key]
        public int PermitId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string EmployeeLastname { get; set; }
        [Required]
        public int PermitTypeId { get; set; }
        public virtual PermitType PermitType { get; set; }
        [Required]
        public DateTime PermitDate { get; set; }
    }
}
