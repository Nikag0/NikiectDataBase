using INotifyChangedCustom;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBcontext
{
    public class QualityPassport : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "nameThis";
        //private FileControlData filePass = new FileControlData();
        private string filePass = "filePass";

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
        public string FilePass
        {
            get => filePass;
            set
            {
                filePass = value;
                NotifyPropertyChanged();
            }
        }
        //public FileControlData FilePass
        //{
        //    get => filePass;
        //    set
        //    {
        //        filePass = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        public override string ToString()
        {
            return NameThis;
        }
    }
}
