using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMApp.Common.VModels
{
    public class EmployeeLeaveTypeVM:BaseVM
    {

        [Required]

        public string Name { get; protected set; }
        public int DefaultDays { get; protected set; }
        public DateTime DateCreted { get; protected set; }


        public void SetEmployeeeType(string name)
        {
            this.Name = name;
        }
    }
}
