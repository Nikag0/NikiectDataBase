using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBcontext
{
    public class MarkMPK : INotifyChanged
    {

        private Guid id = Guid.NewGuid();
        private string nameThis = "";

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


        public override string ToString()
        {
            return NameThis;
        }
    }
}
