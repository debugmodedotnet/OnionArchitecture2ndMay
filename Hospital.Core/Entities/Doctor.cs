using System.ComponentModel.DataAnnotations;

namespace Hospital.Core.Entities
{
 public   class Doctor
    {
     public string DoctorID { get; set; }
     [MaxLength(50)]
     public string Name { get; set; }
     public int PhoneNumber { get; set; }
     
    }
}
