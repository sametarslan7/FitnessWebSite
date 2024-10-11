using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessWebSite.Models.Classes
{
    public class Trainer
    {
        [Key]
        public int id {  get; set; }
        public string trainerName { get; set; }
        public string trainerMajor { get; set; }
        public string trainerDescription { get; set; }
        public string trainerProfilePhoto {  get; set; }
        public int trainerExperience { get; set; }
        public int trainerActiveMember { get; set; }

    }
}