using System;
using System.Collections.Generic;
using System.Text;

namespace EMApp.Data.DbModels
{
    public class EmployeeLeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreted { get; set; }
    }
}
