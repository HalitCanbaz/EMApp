using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMApp.Common.VModels
{
    public class BaseVM
    {
        [Key]
        public int id { get; set; }
        
    }
}
