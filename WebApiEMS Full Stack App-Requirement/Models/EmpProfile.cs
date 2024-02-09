using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEMS_Full_Stack_App_Requirement.Models
{
    [Table("EmpProfile")]
    public class EmpProfile
    {
        [Key]
        public int Empcode {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? EmpName {  get; set; }
        public string? Email { get; set; }
        [ForeignKey("DeptCode")]
        public int DeptCode {  get; set; }
      
    }
}