using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMApp.Data.DbModels
{
    public class Employee : IdentityUser
    {
        public string FirstNAme { get; set; }
        public string LastName { get; set; }
        public string TaxId { get; set; }
        public  DateTime DateOfBirth{ get; set; }

    }
}
