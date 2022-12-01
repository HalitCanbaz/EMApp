using EMApp.Data.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMApp.Data.DataContext
{
    public class EMAppContext : IdentityDbContext
    {
        public EMAppContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeLeaveAllocation> EmployeeLeaveAllocation { get; set; }
        public DbSet<EmployeeLeaveRequest> EmployeeLeaveRequest { get; set; }
        public DbSet<EmployeeLeaveType> EmployeeLeaveType { get; set; }
    }
}
