using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator.ViewModels
{
    class ResultsViewModel : Screen
    {
        private double _bodyMassIndex;

        public double BodyMassIndex
        {
            get { return _bodyMassIndex; }
            set { _bodyMassIndex = value; }
        }

        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private double[] _targetHeartRate;

        public double[] TargetHeartRate
        {
            get { return _targetHeartRate; }
            set { _targetHeartRate = value; }
        }



        private double _maximumHeartRate;

        public double MaximumHeartRate
        {
            get { return _maximumHeartRate; }
            set { _maximumHeartRate = value; }
        }

        public ResultsViewModel(double ABodyMassIndex, string ACategory, double[] ATargetHeartRate, double AMaximumHeartRate)
        {
            _bodyMassIndex = ABodyMassIndex;
            _category = ACategory;
            _targetHeartRate = ATargetHeartRate;
            _maximumHeartRate = AMaximumHeartRate;
        }


    }
}
