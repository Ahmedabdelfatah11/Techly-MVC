using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techly.DAL.Context;
using Techly.DAL.Models;
using Utility;

namespace Techly.DAL.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;

        public DbInitializer(UserManager<IdentityUser> userManager
            ,RoleManager<IdentityRole> roleManager
            ,ApplicationDbContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
        }
        public void Initialize()
        {
            try
            {
                if(_db.Database.GetPendingMigrations().Count()>0)
                {
                    _db.Database.Migrate();
                }
            }
            catch(Exception ex)
            {
                if (!_roleManager.RoleExistsAsync(SD.Role_User_Customer).GetAwaiter().GetResult())
                {
                    _roleManager.CreateAsync(new IdentityRole(SD.Role_User_Customer)).GetAwaiter().GetResult();
                    _roleManager.CreateAsync(new IdentityRole(SD.Role_User_Company)).GetAwaiter().GetResult();
                    _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).GetAwaiter().GetResult();
                    _roleManager.CreateAsync(new IdentityRole(SD.Role_Employee)).GetAwaiter().GetResult();
              
                //If roles aren't  created, we will create admin    
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "admin@Techly.com",
                    Email = "admin@Techly.com",
                    Name = "Techly Admin",
                    PhoneNumber = "01000000000",
                    StreetAddress = "123 Nile St.",
                    State = "GZ",
                    PostalCode = "12511",
                    City = "Giza",

                },"Admin123**").GetAwaiter().GetResult();

                ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "admin@Techly.com");
                _userManager.AddToRoleAsync(user, SD.Role_Admin).GetAwaiter().GetResult();
                }

                return;
            }
        }
    }
}
