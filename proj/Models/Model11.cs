using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proj.Models
{
    public class Model11
    {

        [Key]
        public string ClassTitle { get; set; }
        public string AttendTitle { get; set; }
        public string AbsentTitle { get; set; }
        public Att AttData { get; set; }
    }
        public class Att
        {
            [Key]
            public string Class { get; set; }
            public string Attend { get; set; }
            public string Absent { get; set; }
        }
        public class Entities4 : proj.Entities4
        {
            public IDbSet<Att> Products { get; set; }

        public System.Data.Entity.DbSet<proj.Models.Model11> Model11 { get; set; }
        // other sets 
    }
    }
