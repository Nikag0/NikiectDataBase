using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBcontext
{
    public class ObjModePLV : INotifyChanged
    {

        private Guid id = Guid.NewGuid();
        private Guid idTableGenInforModesPLV;
        private Guid idTableTechnModesPLV;
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
        public Guid IdTableGenInforModesPLV
        {
            get => idTableGenInforModesPLV;
            set
            {
                idTableGenInforModesPLV = value;
                NotifyPropertyChanged();
            }
        }
        public Guid IdTableTechnModesPLV
        {
            get => idTableTechnModesPLV;
            set
            {
                idTableTechnModesPLV = value;
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
        public TableGenInforModesPLV GenInforModesPLV
        {
            get => genInforModesPLV;
            set
            {
                genInforModesPLV = value;
                NotifyPropertyChanged();
            }
        }
        [NotMapped]
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
