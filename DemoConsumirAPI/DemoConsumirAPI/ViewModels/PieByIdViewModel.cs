using DemoConsumirAPI.Services;
using System;
using System.Collections.Generic;
using System.Text;
using DemoConsumirAPI.Model;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.ComponentModel;

namespace DemoConsumirAPI.ViewModels
{
    public class PieByIdViewModel:INotifyPropertyChanged
    {
        Proxy Proxy;

        public event PropertyChangedEventHandler PropertyChanged;

        public PieByIdViewModel()
        {
            SearchPieByIDCommand = new Command(GetPieByID);
            this.Proxy = new Proxy();
            
        }
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void GetPieByID()
        {
            var ID2 = int.Parse(ID);
            Piee = Proxy.GetPieByIdAsync(ID2);
           
        }



        #region Propiedades
        public string ID { get; set; }
        public Command SearchPieByIDCommand { get; set; }
        //public Pie Piee { get; set;  }
        private Pie Pie_BF;

        public Pie Piee
        {
            get { return Pie_BF; }
            set { Pie_BF = value; OnPropertyChanged("Piee"); }
        }

        #endregion
    }
}
