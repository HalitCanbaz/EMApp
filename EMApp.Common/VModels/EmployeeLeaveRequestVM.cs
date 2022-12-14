using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMApp.Common.VModels
{
    public class EmployeeLeaveRequestVM:BaseVM
    {
        public string RequestingEmployeeId { get; set; }
        public EmployeeVM RequestingEmployeeVm { get; set; }



        public string ApprovedEmployeeId { get; set; }
        public EmployeeVM ApprovedEmployeeVm { get; set; }



        public int EmployeeLeaveTypeId { get; set; }
        public EmployeeLeaveTypeVM EmployeeLeaveTypeVm { get; set; }


        //--------------------------------------------------------------------------------------------------

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }


        [Display(Name ="Talep Açıklama")]
        [MaxLength(300, ErrorMessage ="300 Karakterden Fazla Değer Girilemez!")]
        public string RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

    }
}
