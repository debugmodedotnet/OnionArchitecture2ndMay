using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Hospital.Core.Interface;
using Hospital.Infrastructure;

namespace Hospital.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IDoctorRepository, DoctorRepository>();           
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}