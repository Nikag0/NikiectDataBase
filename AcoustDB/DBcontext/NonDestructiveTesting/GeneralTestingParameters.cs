using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class GeneralTestingParameters : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private string typeTool = "";
        private string nameUserIn = "";
        private double valueUserIn = 0;
        private string serialNumber = "";


        public Guid Id
        {
            get => id;
            set
            {
                id = value;
                NotifyPropertyChanged();
            }
        }

        public string NameThis
        {
            get => nameThis;
            set
            {
                nameThis = value;
                NotifyPropertyChanged();
            }
        }

        public string TypeTool
        {
            get => typeTool;
            set
            {
                typeTool = value;
                NotifyPropertyChanged();
            }
        }
        public string NameUserIn
        {
            get => nameUserIn;
            set
            {
                nameUserIn = value;
                NotifyPropertyChanged();
            }
        }
        public double ValueUserIn
        {
            get => valueUserIn;
            set
            {
                valueUserIn = value;
                NotifyPropertyChanged();
            }
        }
        public string SerialNumber
        {
            get => serialNumber;
            set
            {
                serialNumber = value;
                NotifyPropertyChanged();
            }
        }


        public override string ToString()
        {
            return NameThis;
        }
    }
}
