using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMI_Calculator.Core;
using BMI_Calculator.Models;
using System.ComponentModel;

namespace BMI_Calculator.ViewModels
{
    class MainViewModel : Screen
    {
        #region Inputs
        #region Height Input
        private double _heightInput;

        public double HeightInput
        {
            get { return _heightInput; }
            set
            {
                _heightInput = value;
                NotifyOfPropertyChange();
            }
        }

        #endregion
        #region Weight
        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                NotifyOfPropertyChange();
            }
        }
        #endregion
        #region Age
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                NotifyOfPropertyChange();
            }
        }
        #endregion
        #region Sex
        private string _sex;

        public string Sex
        {
            get { return _sex; }
            set
            {
                _sex = value;
                NotifyOfPropertyChange();
            }
        }
        #endregion
        #region Calculation Algorithm

        private string _calculationAlgorithm;

        public string CalculationAlgorithm
        {
            get { return _calculationAlgorithm; }
            set
            {
                _calculationAlgorithm = value;
                NotifyOfPropertyChange();
            }
        }
        #endregion
        #region Intensity Level
        private string _intensityLevel;

        public string IntensityLevel
        {
            get { return _intensityLevel; }
            set
            {
                _intensityLevel = value;
                NotifyOfPropertyChange();
            }
        }
        #endregion
        #endregion



        BodyMassIndex BMI = new BodyMassIndex(5, 3, "Tanaka", 19, "male", "medium");


        public void LoadResultsView()
        {
            
            ActivateItemAsync(new ResultsViewModel(BMI.Result, BMI.Category, BMI.TargetHeartRate, BMI.MaximumHeartRate));
            Console.WriteLine("Results Page");
        }
    }
}
