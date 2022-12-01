using EMApp.Data.Contracts;
using EMApp.Data.DataContext;
using EMApp.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMApp.Data.İmplementaion
{
    public class EmployeeLeaveRequestRepository : Repository<EmployeeLeaveRequest>, IEmployeeLeaveRequestRepository
    {

        private readonly EMAppContext _ctx;

        public EmployeeLeaveRequestRepository(EMAppContext _ctx) : base(_ctx)
        {
        }
    }
}
