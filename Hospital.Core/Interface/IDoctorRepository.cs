using System.Collections.Generic;
using Hospital.Core.Entities;

namespace Hospital.Core.Interface
{
  public  interface IDoctorRepository
    {
      void Add(Doctor d);
      void Edit(Doctor d);
      void Remove(string DoctorID);
      IEnumerable<Doctor> GetDoctors();

      Doctor FindById(string DoctorID);

    }
}
