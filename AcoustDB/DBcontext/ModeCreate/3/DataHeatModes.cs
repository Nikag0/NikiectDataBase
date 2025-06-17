using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class DataHeatModes : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private string type = "";
        private string heatingRate = "";
        private string holdingTemperature = "";
        private string holdingDuration = "";
        private string coolingRate = "";
        private string coolingMedium = "";
        private int numberCycles = 0;

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

        public string Type
        {
            get => type;
            set
            {
                type = value;
                NotifyPropertyChanged();
            }
        }
        public string HeatingRate
        {
            get => heatingRate;
            set
            {
                heatingRate = value;
                NotifyPropertyChanged();
            }
        }
        public string HoldingTemperature
        {
            get => holdingTemperature;
            set
            {
                holdingTemperature = value;
                NotifyPropertyChanged();
            }
        }
        public string HoldingDuration
        {
            get => holdingDuration;
            set
            {
                holdingDuration = value;
                NotifyPropertyChanged();
            }
        }
        public string CoolingRate
        {
            get => coolingRate;
            set
            {
                coolingRate = value;
                NotifyPropertyChanged();
            }
        }
        public string CoolingMedium
        {
            get => coolingMedium;
            set
            {
                coolingMedium = value;
                NotifyPropertyChanged();
            }
        }
        public int NumberCycles
        {
            get => numberCycles;
            set
            {
                numberCycles = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
