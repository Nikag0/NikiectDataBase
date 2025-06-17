using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class TableTechnModesPLV : INotifyChanged
    {

        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private EmptyParamData laserPower = new EmptyParamData();
        private EmptyParamData laserHeadSpeed = new EmptyParamData();
        private EmptyParamData gasConsumptionMPK = new EmptyParamData();
        private EmptyParamData pauseBetweenRollers = new EmptyParamData();
        private EmptyParamData widthOffset = new EmptyParamData();
        private EmptyParamData heightOffset = new EmptyParamData();
        private EmptyParamData consumptionMPK = new EmptyParamData();
        private EmptyParamData tubesKZP = new EmptyParamData();
        private EmptyParamData processKZU = new EmptyParamData();
        private EmptyParamData rollWidth = new EmptyParamData();
        private EmptyParamData rollDiameter = new EmptyParamData();
        private EmptyParamData dateInfo = new EmptyParamData();

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

        public EmptyParamData LaserPower
        {
            get => laserPower;
            set
            {
                laserPower = value;
                NotifyPropertyChanged();
            }
        }
        public EmptyParamData LaserHeadSpeed
        {
            get => laserHeadSpeed;
            set
            {
                laserHeadSpeed = value;
                NotifyPropertyChanged();
            }
        }
        public EmptyParamData GasConsumptionMPK
        {
            get => gasConsumptionMPK;
            set
            {
                gasConsumptionMPK = value;
                NotifyPropertyChanged();
            }
        }
        public EmptyParamData PauseBetweenRollers
        {
            get => pauseBetweenRollers; 
            set
            {
                pauseBetweenRollers = value;
                NotifyPropertyChanged();
            }
        }
        public EmptyParamData WidthOffset
        {
            get => widthOffset; 
            set
            {
                widthOffset = value;
                NotifyPropertyChanged();
            }
        }
        public EmptyParamData HeightOffset
        {
            get => heightOffset; 
            set
            {
                heightOffset = value;
                NotifyPropertyChanged();
            }
        }
        public EmptyParamData ConsumptionMPK
        {
            get => consumptionMPK; 
            set
            {
                consumptionMPK = value;
                NotifyPropertyChanged();
            }
        }
        public EmptyParamData TubesKZP
        {
            get => tubesKZP; 
            set
            {
                tubesKZP = value;
                NotifyPropertyChanged();
            }
        }
        public EmptyParamData ProcessKZU
        {
            get => processKZU; 
            set
            {
                processKZU = value;
                NotifyPropertyChanged();
            }
        }
        public EmptyParamData RollWidth
        {
            get => rollWidth;
            set
            {
                rollWidth = value;
                NotifyPropertyChanged();
            }
        }
        public EmptyParamData RollDiameter
        {
            get => rollDiameter;
            set
            {
                rollDiameter = value;
                NotifyPropertyChanged();
            }
        }
        public EmptyParamData DateInfo
        {
            get => dateInfo;
            set
            {
                dateInfo = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
