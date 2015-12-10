using Project2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project2.DAL
{
    public class MissionContext:DbContext
    {
        public MissionContext()
            : base("MissionContext")
        {

        }
        public DbSet<Missions> Missions { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Users> Users { get; set; }

        //public System.Data.Entity.DbSet<Project2.Models.Missions> Missions { get; set; }
        //public System.Data.Entity.DbSet<Project2.Models.Language> Language { get; set; }
        //public System.Data.Entity.DbSet<Project2.Models.Questions> Questions { get; set; }//This showed up maybe from one of the tutorials
        //public System.Data.Entity.DbSet<Project2.Models.Users> Users { get; set; }//This showed up maybe from one of the tutorials
    }
}