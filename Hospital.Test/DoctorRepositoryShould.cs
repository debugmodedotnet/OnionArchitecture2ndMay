using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Core.Entities;
using Hospital.Core.Interface;
using Hospital.Infrastructure;

namespace Hospital.Test
{
    [TestClass]
   public class DoctorRepositoryShould
    {
        DoctorRepository repo; 
        [TestInitialize]
        public void TestSetup()
        {
            DoctorInitalizeDb db = new DoctorInitalizeDb();
            System.Data.Entity.Database.SetInitializer(db);
            repo = new DoctorRepository();
        }
        [TestMethod]
        public void CreateDBAndInit()
        {
            var result = repo.GetDoctors();
            Assert.IsNotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(2, numberOfRecords);
        }

    }
}
