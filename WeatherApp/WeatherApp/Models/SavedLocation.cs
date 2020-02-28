using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SQLite;
using SQLite.Net.Attributes;

namespace WeatherApp.Models
{
   public class SavedLocation: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Zip { get; set; }
        public string Name { get; set; }
        public double Temp { get; set; }
    }
}
