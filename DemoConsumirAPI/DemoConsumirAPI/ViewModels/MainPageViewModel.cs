using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DemoConsumirAPI.Model;
using DemoConsumirAPI.Services;
namespace DemoConsumirAPI.ViewModels
{
    
    public class MainPageViewModel
    {
        Proxy Proxy;

        public MainPageViewModel()
        {
            this.Proxy = new Proxy();
            GetData();
        }

        void GetData()
        {
            var Datos =  Proxy.GetAllPiesAsync();
            Pies = new ObservableCollection<Pie>(Datos);
        }

        #region Propiedades
        public ObservableCollection<Pie> Pies { get; set; }
        #endregion
    }
}
