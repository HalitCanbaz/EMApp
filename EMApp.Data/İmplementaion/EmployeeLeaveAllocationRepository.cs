using EMApp.Data.Contracts;
using EMApp.Data.DataContext;
using EMApp.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EMApp.Data.İmplementaion
{
    public class EmployeeLeaveAllocationRepository : Repository<EmployeeLeaveAllocation>, IEmployeeLeaveAllocationRepository
    {
        private readonly EMAppContext _ctx;

        public EmployeeLeaveAllocationRepository(EMAppContext ctx) :base(ctx)
        {
            _ctx = ctx;

        }
    }
}
