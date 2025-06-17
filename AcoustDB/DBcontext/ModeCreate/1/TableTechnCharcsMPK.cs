using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class TableTechnCharcsMPK : INotifyChanged
    {

        private Guid id = Guid.NewGuid();
        private string nameThis = "";
        private string granuleSize = "";
        private double bulkDensity;
        private double fluidity = 0;
        private double particleDistribution = 0;
        private double buf0 = 0;
        private double buf1 = 0;


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
        public string GranuleSize
        {
            get => granuleSize;
            set
            {
                granuleSize = value;
                NotifyPropertyChanged();
            }
        }
        public double BulkDensity
        {
            get => bulkDensity;
            set
            {
                bulkDensity = value;
                NotifyPropertyChanged();
            }
        }
        public double Fluidity
        {
            get => fluidity;
            set
            {
                fluidity = value;
                NotifyPropertyChanged();
            }
        }
        public double ParticleDistribution
        {
            get => particleDistribution; 
            set
            {
                particleDistribution = value;
                NotifyPropertyChanged();
            }
        }
        public double Buf0
        {
            get => buf0; 
            set
            {
                buf0 = value;
                NotifyPropertyChanged();
            }
        }
        public double Buf1
        {
            get => buf1; 
            set
            {
                buf1 = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
