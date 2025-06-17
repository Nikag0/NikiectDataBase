using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBcontext
{
    public class TableMicrohardnessMeasur : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private double sampleNumber = 0;
        private double microhardnessHV = 0;

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

        public double SampleNumber
        {
            get => sampleNumber;
            set
            {
                sampleNumber = value;
                NotifyPropertyChanged();
            }
        }
        public double MicrohardnessHV
        {
            get => microhardnessHV;
            set
            {
                microhardnessHV = value;
                NotifyPropertyChanged();
            }
        }


        public override string ToString()
        {
            return NameThis;
        }
    }
}
