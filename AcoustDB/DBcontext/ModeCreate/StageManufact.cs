using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBcontext
{
    public class StageManufact : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private Guid idAllStageObj;
        private Guid idObjMPK;
        private string nameThis = "";

        private ObjMPK  dbObjMPK = new ObjMPK();
        private ObjModePLV dbObjModePLV = new ObjModePLV();
        private ObjHeatModes dbObjHeatModes = new ObjHeatModes();

        public Guid Id
        {
            get => id;
            set
            {
                id = value;
                NotifyPropertyChanged();
            }
        }
        public Guid IdAllStageObj
        {
            get => idAllStageObj;
            set
            {
                idAllStageObj = value;
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
        public Guid IdObjMPK
        {
            get => idObjMPK;
            set
            {
                idObjMPK = value;
                NotifyPropertyChanged();
            }
        }
        
        [NotMapped]
        public ObjMPK DbObjMPK
        {
            get => dbObjMPK;
            set
            {
                dbObjMPK = value;
                NotifyPropertyChanged();
            }
        }
        [NotMapped]
        public ObjModePLV DbObjModePLV
        {
            get => dbObjModePLV;
            set
            {
                dbObjModePLV = value;
                NotifyPropertyChanged();
            }
        }
        [NotMapped]
        public ObjHeatModes DbObjHeatModes
        {
            get => dbObjHeatModes;
            set
            {
                dbObjHeatModes = value;
                NotifyPropertyChanged();
            }
        }
        public override string ToString()
        {
            return NameThis;
        }
    }
}
