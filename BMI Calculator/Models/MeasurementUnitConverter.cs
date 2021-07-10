using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator.Models
{
    class MeasurementUnitConverter
    {
        public static bool isMetricSystemActive = true;

        static void SwitchMeasurementUnits(double Height, double Weight)
        {
            isMetricSystemActive = !isMetricSystemActive;

            if (isMetricSystemActive) // User wants to switch to imperial unit system, therefore theese values need to be updated
            {
                Height *= 39.3701f;
                Weight *= 2.205f;
            }
            else
            {
                Height /= 39.3701f;
                Weight /= 2.205f;
            }
        }

        public static double CalculateBMI(double Height, double Weight)
        {
            if (isMetricSystemActive)
            {
                return Weight / Math.Pow(Height, 2);
            }
            else
            {
                return Weight * 704 / Math.Pow(Height, 2);
            }
        }
    }
}
