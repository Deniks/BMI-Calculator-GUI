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
    public class ShellViewModel : Conductor<object>
    {


        public ShellViewModel()
        {
            LoadMainView();
        }

        public void LoadMainView()
        {
            ActivateItemAsync(new MainViewModel());
        }
    }

}
