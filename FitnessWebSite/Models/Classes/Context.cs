using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FitnessWebSite.Models.Classes
{
    public class Context : DbContext
    {

        public DbSet<FreeProgram> FreePrograms {  get; set; }
        public DbSet<GroupClass> GroupClasses {  get; set; } 
        public DbSet<PrivateProgram> Programs {  get; set; } 
        public DbSet<Trainer> Trainers {  get; set; } 
        public DbSet<Admin> Admins { get; set; }

    }
}