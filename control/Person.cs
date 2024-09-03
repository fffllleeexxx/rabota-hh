using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control
{
    public class Person
    {
        public string Name { get; set; }
        public double Commissions { get; set; }
        public int Revenue { get; set; }
        public string Seniority { get; set; }

        public Person(string name, double comi, int rev, string sen)
        {
            Name = name;
            Commissions = comi;
            Revenue = rev;
            Seniority = sen;
        }
    }
}
