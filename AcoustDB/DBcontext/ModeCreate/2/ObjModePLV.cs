using INotifyChangedCustom;
using System;
using System.Collections.Generic;

namespace DBcontext
{
    public class ObjModePLV : INotifyChanged
    {

        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private TableGenInforModesPLV genInforModesPLV = new TableGenInforModesPLV();
        private TableTechnModesPLV technModesPLV = new TableTechnModesPLV();

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

        public TableGenInforModesPLV GenInforModesPLV
        {
            get => genInforModesPLV;
            set
            {
                genInforModesPLV = value;
                NotifyPropertyChanged();
            }
        }
        public TableTechnModesPLV TechnModesPLV
        {
            get => technModesPLV;
            set
            {
                technModesPLV = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
