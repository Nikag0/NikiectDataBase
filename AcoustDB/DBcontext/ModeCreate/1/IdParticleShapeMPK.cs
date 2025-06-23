using DocumentFormat.OpenXml.Office2010.Excel;
using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcoustDB.DBcontext.ModeCreate._1
{
    public class IdParticleShapeMPK : INotifyChanged
    {
        private Guid idObjMPK = Guid.NewGuid();
        private Guid idTableParticleShape = Guid.NewGuid();

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
        public Guid IdTableParticleShape
        {
            get => idTableParticleShape;
            set
            {
                idTableParticleShape = value;
                NotifyPropertyChanged();
            }
        }
    }
}
