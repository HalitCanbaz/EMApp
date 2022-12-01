using EMApp.Data.Contracts;
using EMApp.Data.DataContext;
using EMApp.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMApp.Data.İmplementaion
{
    public class EmployeeLeaveTypeRepository : Repository<EmployeeLeaveType>, IEmployeeLeaveTypeRepository
    {
        private readonly EMAppContext _ctx;
        public EmployeeLeaveTypeRepository(EMAppContext _ctx) : base(_ctx)
        {
        }






    }
}
