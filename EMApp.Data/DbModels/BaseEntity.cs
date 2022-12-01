using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMApp.Data.DbModels
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

    }
}
