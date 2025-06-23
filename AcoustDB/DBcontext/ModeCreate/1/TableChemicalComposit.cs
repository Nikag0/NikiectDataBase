using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcoustDB.DBcontext.ModeCreate._1
{
    public class TableChemicalComposit : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";
        private string element = "";
        private string factValue = "";
        private string referenceValue = "";

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
        public string Element
        {
            get => element;
            set
            {
                element = value;
                NotifyPropertyChanged();
            }
        }
        public string FactValue
        {
            get => factValue;
            set
            {
                factValue = value;
                NotifyPropertyChanged();
            }
        }
        public string ReferenceValue
        {
            get => referenceValue;
            set
            {
                referenceValue = value;
                NotifyPropertyChanged();
            }
        }
        public override string ToString()
        {
            return NameThis;
        }
    }
}
