using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessWebSite.Models.Classes
{
    public class GroupClass
    {
        [Key]
        public int id { get; set; }
        public string className  { get; set; }
        public string classDetail { get; set; }
        public string classFilePath { get; set; }

    }
}