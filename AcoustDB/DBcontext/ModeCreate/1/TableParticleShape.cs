using INotifyChangedCustom;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBcontext
{
    public class TableParticleShape : INotifyChanged
    {

        private Guid id = Guid.NewGuid();
        private Guid idParticleShape = Guid.NewGuid();
        private string nameThis = "";

        private ParticleShape shape = new ParticleShape();
        private string particleContent = "";
        private string referenceValue = "";

        public Guid Id
        {
            get => id;
            set
            {
                id = value;
                NotifyPropertyChanged();
            }
        }
        public Guid IdParticleShape
        {
            get => idParticleShape;
            set
            {
                idParticleShape = value;
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
        public ParticleShape Shape
        {
            get => shape;
            set
            {
                shape = value;
                NotifyPropertyChanged();
            }
        }
        public string ParticleContent
        {
            get => particleContent;
            set
            {
                particleContent = value;
                NotifyPropertyChanged();
            }
        }
        public string ReferenceValue
        {
            get => referenceValue;
            set
            {
                referenceValue = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
