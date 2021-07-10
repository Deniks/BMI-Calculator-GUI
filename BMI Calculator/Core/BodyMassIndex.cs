using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMI_Calculator.Models;

namespace BMI_Calculator.Core
{
    class BodyMassIndex
    {
        private double _bodyMassIndex;

        public double Result
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

        private double _maximumHeartRate;

        public double MaximumHeartRate
        {
            get { return _maximumHeartRate; }
            set { _maximumHeartRate = value; }
        }

        private double[] _targetHeartRate = new double[2];

        public double[] TargetHeartRate
        {
            get { return _targetHeartRate; }
            set { _targetHeartRate = value; }
        }


        private double _height;
        private double _weight;
        private string _calculationAlgorithm;
        private int _age;
        private string _sex;
        private string _intensityLevel;


        public BodyMassIndex(double Height, double Weight, string CalculationAlgorithm, int Age, string Sex, string IntensityLevel)
        {
            _height = Height;
            _weight = Weight;
            _calculationAlgorithm = CalculationAlgorithm;
            _age = Age;
            _sex = Sex;
            _intensityLevel = IntensityLevel;
            Run();
        }
        private void DetermineMaximumHeartRate()
        {
            switch (_calculationAlgorithm)
            {
                case "Tanaka":
                    _maximumHeartRate = MaximumHeartRateCalculationAlgorithms.Tanaka(_age);
                    break;
                case "Gellish":
                    _maximumHeartRate = MaximumHeartRateCalculationAlgorithms.Tanaka(_age);
                    break;
                case "CERG":
                    _maximumHeartRate = MaximumHeartRateCalculationAlgorithms.CERG(_age);
                    break;
                case "Fairburn":
                    _maximumHeartRate = MaximumHeartRateCalculationAlgorithms.Fairburn(_age, _sex);
                    break;
            }
        }

        private void CalculateBMI()
        {
            if (true)
            {
                _bodyMassIndex = Math.Round(_weight / Math.Pow(_height, 2), 2);
            }
            else
            {
                _bodyMassIndex = Math.Round(_weight * 704 / Math.Pow(_height, 2), 2);
            }
        }

        private void DetermineCategory()
        {
            if (_bodyMassIndex < 18.5)
            {
                _category = "Underweight";
            }
            else if (_bodyMassIndex >= 18.5 && _bodyMassIndex < 25)
            {
                _category = "Normal";
            }
            else if (_bodyMassIndex >= 25 && _bodyMassIndex < 30)
            {
                _category = "Overweight";
            }
            else if (_bodyMassIndex >= 30 && _bodyMassIndex < 35)
            {
                _category = "Obese Class 1";
            }
            else if (_bodyMassIndex >= 35 && _bodyMassIndex < 40)
            {
                _category = "Obese Class 2";
            }
            else if (_bodyMassIndex >= 40)
            {
                _category = "Obese Class 3";
            }
        }

        private void CalculateMaximumHeartRate()
        {
            _maximumHeartRate = 220 - _age;
        }
        private void DetermineTargetHeartRate()
        {
            if (_intensityLevel == "Low")
            {
                _targetHeartRate[0] = _maximumHeartRate * 0.5;
                _targetHeartRate[1] = _maximumHeartRate * 0.7;
            }
            else if (_intensityLevel == "Moderate")
            {
                _targetHeartRate[0] = _maximumHeartRate * 0.7;
                _targetHeartRate[1] = _maximumHeartRate * 0.8;
            }
            else if (_intensityLevel == "High")
            {
                _targetHeartRate[0] = _maximumHeartRate * 0.8;
                _targetHeartRate[1] = _maximumHeartRate * 0.9;
            }
            else if (_intensityLevel == "Maximum")
            {
                _targetHeartRate[0] = _maximumHeartRate * 0.9;
                _targetHeartRate[1] = _maximumHeartRate * 1;
            }
            Math.Round(_targetHeartRate[0], 2);
            Math.Round(_targetHeartRate[1], 2);
        }

        private void DebugResults()
        {
            Console.WriteLine(
                $"{_bodyMassIndex}" +
                $"Your result suggests you are {_category}" +
                $"{_targetHeartRate}"
            //1 $"Target heart rate is between {targetHeartRate[0]} and {targetHeartRate[1]}"
            );
        }

        public void Run()
        {
            CalculateBMI();
            DetermineMaximumHeartRate();
            DetermineCategory();
            CalculateMaximumHeartRate();
            DetermineTargetHeartRate();
        }
    }
}
