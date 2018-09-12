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
        IProxy Proxy;

        public MainPageViewModel()
        {
            this.Proxy = new Proxy();
            GetData();
        }

        async void GetData()
        {
            var Datos = await Proxy.GetAllPies();
            Pies = new ObservableCollection<Pie>(Datos);
        }

        #region Propiedades
        public ObservableCollection<Pie> Pies { get; set; }
        #endregion
    }
}
