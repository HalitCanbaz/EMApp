using AutoMapper;
using EMApp.Common.VModels;
using EMApp.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMApp.Common.Mapping
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<EmployeeLeaveType, EmployeeLeaveTypeVM>().ReverseMap();
            CreateMap<EmployeeLeaveAllocation, EmployeeLeaveAllocationVM>().ReverseMap();
            CreateMap<EmployeeLeaveRequest, EmployeeLeaveRequestVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();


        }
    }
}
