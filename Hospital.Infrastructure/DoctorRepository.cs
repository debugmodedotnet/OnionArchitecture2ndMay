using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Core.Interface;
using Hospital.Core.Entities;

namespace Hospital.Infrastructure
{
  public  class DoctorRepository : IDoctorRepository
    {
      DoctorContext context = new DoctorContext();

        public void Add(Doctor d)
        {

            context.Doctors.Add(d);
            context.SaveChanges();
        }

        public void Edit(Doctor d)
        {
            context.Entry(d).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(string DoctorID)
        {
            Doctor b = context.Doctors.Find(DoctorID);
            context.Doctors.Remove(b);
            context.SaveChanges();
        }

        public IEnumerable<Doctor> GetDoctors()
        {

            return context.Doctors;
           
        }

        public Doctor FindById(string DoctorID)
        {
            var dc = (from r in context.Doctors where r.DoctorID == DoctorID select r).FirstOrDefault();
            return dc;
        }
    }
}
