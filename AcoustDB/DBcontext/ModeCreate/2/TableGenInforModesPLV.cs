using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class TableGenInforModesPLV : INotifyChanged
    {

        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private DateTime dateRelease = DateTime.Now;
        private string equipment = "";
        private string manufacture = "";
        private string operatorUser = "";

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

        public DateTime DateRelease
        {
            get => dateRelease;
            set
            {
                dateRelease = value;
                NotifyPropertyChanged();
            }
        }

        public string Equipment
        {
            get => equipment;
            set
            {
                equipment = value;
                NotifyPropertyChanged();
            }
        }
        public string Manufacture
        {
            get => manufacture;
            set
            {
                manufacture = value;
                NotifyPropertyChanged();
            }
        }
        public string OperatorUser
        {
            get => operatorUser;
            set
            {
                operatorUser = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
