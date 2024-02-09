using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiEMS_Full_Stack_App_Requirement.Models;

namespace WebApiEMS_Full_Stack_App_Requirement.Data
{
    public class EmpolyeeContext : DbContext
    {
        public EmpolyeeContext (DbContextOptions<EmpolyeeContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiEMS_Full_Stack_App_Requirement.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
