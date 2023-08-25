using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VizyonAuto.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace VizyonAuto.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            // Rolleri
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Description = "admin rolü" };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user rolü" }; ;
                manager.Create(role);
            }

            if (!context.Users.Any(i => i.Name == "ovuncmert"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = " ovunc mert", Surname = "kartal", UserName = "ovuncmert", Email = "ovuncmertkartal@gmail.com" };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "admin");

            }

            if (!context.Users.Any(i => i.Name == "murat12"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "murat", Surname = "agca", UserName = "murat12", Email = "murat12@gmail.com" };

                manager.Create(user, "7654321");
                manager.AddToRole(user.Id, "user");
            }



            base.Seed(context);
        }
    }
}