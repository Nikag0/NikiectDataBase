using INotifyChangedCustom;
using System;
using System.ComponentModel.DataAnnotations;

namespace DBcontext
{
    public class IdChemicalCompositMPK : INotifyChanged
    {
        private Guid idObjMPK = Guid.NewGuid();
        private Guid idTableChemicalComposit = Guid.NewGuid();

        [Key]
        public Guid IdObjMPK
        {
            get => idObjMPK;
            set
            {
                idObjMPK = value;
                NotifyPropertyChanged();
            }
        }
        public Guid IdTableChemicalComposit
        {
            get => idTableChemicalComposit;
            set
            {
                idTableChemicalComposit = value;
                NotifyPropertyChanged();
            }
        }
    }
}
