using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessWebSite.Models.Classes
{
    public class FreeProgram
    {
        [Key]
        public int id { get; set; }
        public string freeProgramName  { get; set; }
        public string freeProgramDetail  { get; set; }
        public string freeProgramFilePath { get; set; }
    }
}