using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using TTT.Data.ViewModels;

namespace TTT.Data
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {

            var container = new UnityContainer();

            
            container.RegisterType<SettingsViewModel, SettingsViewModel>();





            SettingsViewModel = container.Resolve<SettingsViewModel>();
        }

        public SettingsViewModel SettingsViewModel { get; set; }



    }
}
