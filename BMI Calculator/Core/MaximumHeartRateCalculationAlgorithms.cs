using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator.Core
{
    class MaximumHeartRateCalculationAlgorithms
    {
        public static double Tanaka(int age)
        {
            return 208 - (0.7 * age);
        }

        public static double Gellish(int age)
        {
            return 206.9 - (0.67 * age);
        }

        public static double Gellish2(int age)
        {
            return 191.5 - 0.007 * (Math.Pow(age, 2));
        }

        public static double CERG(int age)
        {
            return 211 - 0.64 * age;
        }

        public static double Fairburn(int age, string sex)
        {
            return sex == "male" ? 208 - 0.8 * age : 201 - 0.63 * age;
        }
    }
}
