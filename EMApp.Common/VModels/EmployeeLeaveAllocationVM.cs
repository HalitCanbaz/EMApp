﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EMApp.Common.VModels
{
    public class EmployeeLeaveAllocationVM:BaseVM
    {
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }


        public string EmployeeId { get; set; }
        public EmployeeVM EmployeeVm { get; set; }


        public int EmloyeeLeaveTypeId { get; set; }
        public EmployeeLeaveTypeVM EmloyeeLeaveTypeVm { get; set; }
    }


}
