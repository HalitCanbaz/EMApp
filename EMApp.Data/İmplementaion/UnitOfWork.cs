using EMApp.Data.Contracts;
using EMApp.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMApp.Data.İmplementaion
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EMAppContext _ctx;


        public UnitOfWork(EMAppContext ctx)
        {
            _ctx = ctx;
            employeeLeaveAllocation = new EmployeeLeaveAllocationRepository(_ctx);
            employeeLeaveRequestRepository = new EmployeeLeaveRequestRepository(_ctx);
            employeeLeaveTypeRepository = new EmployeeLeaveTypeRepository(_ctx);
        }

        public IEmployeeLeaveAllocationRepository employeeLeaveAllocation { get; private set; }
        public IEmployeeLeaveRequestRepository employeeLeaveRequestRepository { get; private set; }
        public IEmployeeLeaveTypeRepository employeeLeaveTypeRepository { get; private set; }


        public void Save()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }


    }
}
