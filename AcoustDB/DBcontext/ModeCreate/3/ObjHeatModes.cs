using AcoustDB.DBcontext.ModeCreate._1;
using AcoustDB.DBcontext.ModeCreate._3;
using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBcontext
{
    public class ObjHeatModes : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";
        private ObservableCollection<TableDataHeatModes> tableDataHeatModes = new ObservableCollection<TableDataHeatModes>();
        private ObservableCollection<IdDataHeatModes> idDataHeatModes = new ObservableCollection<IdDataHeatModes>();

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
        [NotMapped]
        public ObservableCollection<TableDataHeatModes> TableDataHeatModes
        {
            get => tableDataHeatModes;
            set
            {
                tableDataHeatModes = value;
                NotifyPropertyChanged();
            }
        }
        [NotMapped]
        public ObservableCollection<IdDataHeatModes> IdDataHeatModes
        {
            get => idDataHeatModes;
            set
            {
                idDataHeatModes = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
