using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessWebSite.Models.Classes
{
    public class Admin
    {
        [Key]
        public int Id { get; set; } 
        public string username { get; set; }
        public string password { get; set; }

    }
}