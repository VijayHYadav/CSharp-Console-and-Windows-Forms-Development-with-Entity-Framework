﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary5
{
    public class Student
    {
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }

        public List<Examination> examinations { get; set; }
    }
}
