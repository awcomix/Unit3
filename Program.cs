using System;
using System.Collections.Generic;
using PasswordGenerator;

namespace Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
            var bloodType1 = new BloodType("AB", '-');
            var bloodType2 = new BloodType("0", '+');
            
            bool canWeDonate1to2 = bloodType1.CanDonateTo(bloodType2);
            bool canWeDonate2to1 = bloodType2.CanDonateTo(bloodType1);
        }

    }
}

