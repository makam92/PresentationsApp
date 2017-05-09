using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using PresentationsApp.viewmodels;

namespace PresentationsApp
{
    public class Locator
    {
        static Locator()
        {
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public static MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();
    }
}
