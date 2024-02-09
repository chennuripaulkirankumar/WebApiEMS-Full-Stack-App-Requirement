using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEMS_Full_Stack_App_Requirement.Models
{
    [Table ("DeptMAster")]
    public class DeptMaster
    {
        [Key]
        public int DeptCode { get; set; }    
        public string? DeptName { get; set; }
        public ICollection<EmpProfile>?EmpProfiles { get; set; }

    }
}
