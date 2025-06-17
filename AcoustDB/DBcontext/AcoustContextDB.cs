using INotifyChangedCustom;
using System.Collections.Generic;

namespace DBcontext
{
    public class AcoustContextDB : INotifyChanged
    {
        public AcoustContextDB()
        {

        }


        /////////////-------StageManufact-------//////////////
        private List<StageManufact> dbSetStageManufact = new List<StageManufact>();


        /////////////-------1-------//////////////
        private List<ObjMPK> dbSetObjMPK = new List<ObjMPK>();

        private List<QualityPassport> dbSetQualityPassport = new List<QualityPassport>();
        private List<MarkMPK> dbSetMarkMPK = new List<MarkMPK>();

        private List<TableBasicInfoMPK> dbSetTableBasicInfoMPK = new List<TableBasicInfoMPK>();
        private List<TableTechnCharcsMPK> dbSetTableTechnCharcsMPK = new List<TableTechnCharcsMPK>();
        private List<TableParticleShape> dbSetTableParticleShape = new List<TableParticleShape>();
        private List<TableChemicalCompositMPK> dbSetTableChemicalCompositMPK = new List<TableChemicalCompositMPK>();

        /////////////-------2-------//////////////
        private List<ObjModePLV> dbSetObjModePLV = new List<ObjModePLV>();

        private List<TableGenInforModesPLV> dbSetTableGenInforModesPLV = new List<TableGenInforModesPLV>();
        private List<TableTechnModesPLV> dbSetTableTechnModesPLV = new List<TableTechnModesPLV>();

        /////////////-------3-------//////////////
        private List<ObjHeatModes> dbSetObjHeatModes = new List<ObjHeatModes>();

        private List<DataHeatModes> dbSetDataHeatModes = new List<DataHeatModes>();




        public List<StageManufact> DbSetStageManufact
        {
            get => dbSetStageManufact;
            set
            {
                dbSetStageManufact = value;
                NotifyPropertyChanged();
            }
        }
        public List<ObjMPK> DbSetObjMPK
        {
            get => dbSetObjMPK;
            set
            {
                dbSetObjMPK = value;
                NotifyPropertyChanged();
            }
        }
        public List<QualityPassport> DbSetQualityPassport
        {
            get => dbSetQualityPassport; set
            {
                dbSetQualityPassport = value;
                NotifyPropertyChanged();
            }
        }
        public List<MarkMPK> DbSetMarkMPK
        {
            get => dbSetMarkMPK; set
            {
                dbSetMarkMPK = value;
                NotifyPropertyChanged();
            }
        }
        public List<TableBasicInfoMPK> DbSetTableBasicInfoMPK
        {
            get => dbSetTableBasicInfoMPK;
            set
            {
                dbSetTableBasicInfoMPK = value;
                NotifyPropertyChanged();
            }
        }
        public List<TableTechnCharcsMPK> DbSetTableTechnCharcsMPK
        {
            get => dbSetTableTechnCharcsMPK;
            set
            {
                dbSetTableTechnCharcsMPK = value;
                NotifyPropertyChanged();
            }
        }
        public List<TableParticleShape> DbSetTableParticleShape
        {
            get => dbSetTableParticleShape;
            set
            {
                dbSetTableParticleShape = value;
                NotifyPropertyChanged();
            }
        }
        public List<TableChemicalCompositMPK> DbSetTableChemicalCompositMPK
        {
            get => dbSetTableChemicalCompositMPK;
            set
            {
                dbSetTableChemicalCompositMPK = value;
                NotifyPropertyChanged();
            }
        }
        public List<ObjModePLV> DbSetObjModePLV
        {
            get => dbSetObjModePLV;
            set
            {
                dbSetObjModePLV = value;
                NotifyPropertyChanged();
            }
        }
        public List<TableGenInforModesPLV> DbSetTableGenInforModesPLV
        {
            get => dbSetTableGenInforModesPLV;
            set
            {
                dbSetTableGenInforModesPLV = value;
                NotifyPropertyChanged();
            }
        }
        public List<TableTechnModesPLV> DbSetTableTechnModesPLV
        {
            get => dbSetTableTechnModesPLV;
            set
            {
                dbSetTableTechnModesPLV = value;
                NotifyPropertyChanged();
            }
        }
        public List<ObjHeatModes> DbSetObjHeatModes
        {
            get => dbSetObjHeatModes;
            set
            {
                dbSetObjHeatModes = value;
                NotifyPropertyChanged();
            }
        }
        public List<DataHeatModes> DbSetDataHeatModes
        {
            get => dbSetDataHeatModes;
            set
            {
                dbSetDataHeatModes = value;
                NotifyPropertyChanged();
            }
        }
    }
}
