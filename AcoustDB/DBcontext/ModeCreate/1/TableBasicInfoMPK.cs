using DocumentFormat.OpenXml.Office2010.Excel;
using INotifyChangedCustom;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBcontext
{
    public class TableBasicInfoMPK : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";
        private MarkMPK markMPK = new MarkMPK();
        private Guid idMarkMPK;
        private string batchNumber = "";
        private string typePackaging = "";
        private string manufacture = "";
        private string normatDoc = "";
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
        public Guid IdMarkMPK
        {
            get => idMarkMPK;
            set
            {
                idMarkMPK = value;
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
        public MarkMPK MarkMPK
        {
            get => markMPK;
            set
            {
                markMPK = value;
                NotifyPropertyChanged();
            }
        }
        public string BatchNumber
        {
            get => batchNumber;
            set
            {
                batchNumber = value;
                NotifyPropertyChanged();
            }
        }
        public string TypePackaging
        {
            get => typePackaging; 
            set
            {
                typePackaging = value;
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
        public string NormatDoc
        {
            get => normatDoc; 
            set
            {
                normatDoc = value;
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

        public override string ToString()
        {
            return NameThis;
        }
    }
}
