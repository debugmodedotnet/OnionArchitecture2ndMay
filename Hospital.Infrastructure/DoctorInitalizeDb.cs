using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Core.Entities;
using System.Data.Entity;

namespace Hospital.Infrastructure
{
    public class DoctorInitalizeDb  : DropCreateDatabaseIfModelChanges<DoctorContext>
    {

        protected override void Seed(DoctorContext context)
        {
            context.Doctors.Add(new Doctor
            {
                DoctorID = "d1",
                Name = "DJ",
                PhoneNumber = 7989
            });
            context.Doctors.Add(new Doctor
            {
                DoctorID = "d2",
                Name = "Rahul",
                PhoneNumber = 4566
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
