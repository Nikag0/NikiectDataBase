using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class ParticleShape : INotifyChanged
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
