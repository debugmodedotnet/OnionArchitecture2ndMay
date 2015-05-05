using Hospital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Infrastructure
{
   public class DoctorContext : DbContext
    {
       public DoctorContext() 
           :base("name=hcs")
       {
       }
       public DbSet<Doctor> Doctors { get; set; }
    }
}
