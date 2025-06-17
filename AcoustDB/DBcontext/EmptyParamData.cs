using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class EmptyParamData : INotifyChanged
    {
        public EmptyParamData()
        {

        }


        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private string paramString = "";
        private int paramInt = 0;
        private double paramDouble = 0;

        private DateTime dateRelease = DateTime.Now;

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
        public string ParamString
        {
            get => paramString;
            set
            {
                paramString = value;
                NotifyPropertyChanged();
            }
        }
        public int ParamInt
        {
            get => paramInt;
            set
            {
                paramInt = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble
        {
            get => paramDouble;
            set
            {
                paramDouble = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
