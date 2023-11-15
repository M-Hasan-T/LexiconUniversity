﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace University.Core.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int Grade { get; set; }

        //Conv 1 nullable foreign key!!
        //public Student Student { get; set; }

        //Conv 3 = Conv 1 + Conv 2
        //public Student Student { get; set; }

        //Conv 4 add foreign key
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
