using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBcontext
{
    public class ObjHeatModes : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";
        private List<DataHeatModes> tableDataHeatModes = new List<DataHeatModes>();


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

        public List<DataHeatModes> TableDataHeatModes
        {
            get => tableDataHeatModes;
            set
            {
                tableDataHeatModes = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
