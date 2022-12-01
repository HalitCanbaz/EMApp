using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EMApp.Data.DbModels
{
    public class EmployeeLeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }


        public string EmployeeId { get; set; }
        [ForeignKey("EmloyeeId")]
        public Employee Employee { get; set; }


        public int EmloyeeLeaveTypeId { get; set; }
        [ForeignKey("EmloyeeLeaveTypeId")]
        public EmployeeLeaveType EmloyeeLeaveType { get; set; }


    }
}
