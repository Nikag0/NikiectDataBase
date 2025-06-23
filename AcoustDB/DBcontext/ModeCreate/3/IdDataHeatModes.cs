using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcoustDB.DBcontext.ModeCreate._3
{
    public class IdDataHeatModes : INotifyChanged
    {
        private Guid idObjHeatModes = Guid.NewGuid();
        private Guid idTableDataHeatModes = Guid.NewGuid();

        [Key]
        public Guid IdObjHeatModes
        {
            get => idObjHeatModes;
            set
            {
                idObjHeatModes = value;
                NotifyPropertyChanged();
            }
        }
        public Guid IdTableDataHeatModes
        {
            get => idTableDataHeatModes;
            set
            {
                idTableDataHeatModes = value;
                NotifyPropertyChanged();
            }
        }
    }
}
