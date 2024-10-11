using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessWebSite.Models.Classes
{
    public class PrivateProgram
    {
        [Key]
        public int id { get; set; }
        public string programName { get; set; }
        public string programDetail { get; set; }
    }
}