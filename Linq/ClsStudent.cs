﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class ClsStudent
    {

        //Advanced C# way to write classes with lambda expression to redirect the content LOVEEEEEEEEEEEE!
        private string vName, vProgram;
        private Single vAverage;

        public string Name { get => vName; set => vName = value; }      

        public string Program { get => vProgram; set => vProgram = value; }

        public float Average { get => vAverage; set => vAverage = value; }

        public ClsStudent(string name, string program, Single average)
        {
            this.vName = name;
            this.vProgram = program;
            this.vAverage = average;       
        
        }
            




        


    }
}
