using System;
using System.Collections.Generic;
using System.Text;

namespace Ostara
{
    public class Restaurant
    {
        public string Name { get; }
        public string Email { get; }
        public string AdressOfRes { get; }
        public string SpecsofRes { get; }
        public double MarkofRes { get; }

        public Restaurant(string nameOfRes, string mail, string adress, string specs, double mark)
        {
            Name = nameOfRes;
            Email = mail;
            AdressOfRes = adress;
            SpecsofRes = specs;
            MarkofRes = mark;
        }


    }
}
