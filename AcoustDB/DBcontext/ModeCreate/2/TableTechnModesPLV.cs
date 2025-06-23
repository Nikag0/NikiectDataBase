using INotifyChangedCustom;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBcontext
{
    public class TableTechnModesPLV : INotifyChanged
    {

        private Guid id = Guid.NewGuid();
        private string nameThis = "";
        private string laserPower = "";
        private string laserHeadSpeed = "";
        private string gasConsumptionMPK = "";
        private string pauseBetweenRollers = "";
        private string widthOffset = "";
        private string heightOffset = "";
        private string consumptionMPK = "";
        private string tubesKZP = ""    ;
        private string processKZU = "";
        private string rollWidth = "";
        private string rollDiameter = "";
        private DateTime dateInfo = DateTime.Now;

        /*
        //private EmptyParamData laserPower = new EmptyParamData();
        //private EmptyParamData laserHeadSpeed = new EmptyParamData();
        //private EmptyParamData gasConsumptionMPK = new EmptyParamData();
        //private EmptyParamData pauseBetweenRollers = new EmptyParamData();
        //private EmptyParamData widthOffset = new EmptyParamData();
        //private EmptyParamData heightOffset = new EmptyParamData();
        //private EmptyParamData consumptionMPK = new EmptyParamData();
        //private EmptyParamData tubesKZP = new EmptyParamData();
        //private EmptyParamData processKZU = new EmptyParamData();
        //private EmptyParamData rollWidth = new EmptyParamData();
        //private EmptyParamData rollDiameter = new EmptyParamData();
        //private EmptyParamData dateInfo = new EmptyParamData();
        */

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
        public string LaserPower
        {
            get => laserPower;
            set
            {
                laserPower = value;
                NotifyPropertyChanged();
            }
        }
        public string LaserHeadSpeed
        {
            get => laserHeadSpeed;
            set
            {
                laserHeadSpeed = value;
                NotifyPropertyChanged();
            }
        }
        public string GasConsumptionMPK
        {
            get => gasConsumptionMPK;
            set
            {
                gasConsumptionMPK = value;
                NotifyPropertyChanged();
            }
        }
        public string PauseBetweenRollers
        {
            get => pauseBetweenRollers;
            set
            {
                pauseBetweenRollers = value;
                NotifyPropertyChanged();
            }
        }
        public string WidthOffset
        {
            get => widthOffset;
            set
            {
                widthOffset = value;
                NotifyPropertyChanged();
            }
        }
        public string HeightOffset
        {
            get => heightOffset;
            set
            {
                heightOffset = value;
                NotifyPropertyChanged();
            }
        }
        public string ConsumptionMPK
        {
            get => consumptionMPK;
            set
            {
                consumptionMPK = value;
                NotifyPropertyChanged();
            }
        }
        public string TubesKZP
        {
            get => tubesKZP;
            set
            {
                tubesKZP = value;
                NotifyPropertyChanged();
            }
        }
        public string ProcessKZU
        {
            get => processKZU;
            set
            {
                processKZU = value;
                NotifyPropertyChanged();
            }
        }
        public string RollWidth
        {
            get => rollWidth;
            set
            {
                rollWidth = value;
                NotifyPropertyChanged();
            }
        }
        public string RollDiameter
        {
            get => rollDiameter;
            set
            {
                rollDiameter = value;
                NotifyPropertyChanged();
            }
        }
        public DateTime DateInfo
        {
            get => dateInfo;
            set
            {
                dateInfo = value;
                NotifyPropertyChanged();
            }
        }

        /*
        //[NotMapped]
        //public EmptyParamData LaserPower
        //{
        //    get => laserPower;
        //    set
        //    {
        //        laserPower = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        //[NotMapped]
        //public EmptyParamData LaserHeadSpeed
        //{
        //    get => laserHeadSpeed;
        //    set
        //    {
        //        laserHeadSpeed = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        //[NotMapped]
        //public EmptyParamData GasConsumptionMPK
        //{
        //    get => gasConsumptionMPK;
        //    set
        //    {
        //        gasConsumptionMPK = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        //[NotMapped]
        //public EmptyParamData PauseBetweenRollers
        //{
        //    get => pauseBetweenRollers; 
        //    set
        //    {
        //        pauseBetweenRollers = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        //[NotMapped]
        //public EmptyParamData WidthOffset
        //{
        //    get => widthOffset; 
        //    set
        //    {
        //        widthOffset = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        //[NotMapped]
        //public EmptyParamData HeightOffset
        //{
        //    get => heightOffset; 
        //    set
        //    {
        //        heightOffset = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        //[NotMapped]
        //public EmptyParamData ConsumptionMPK
        //{
        //    get => consumptionMPK; 
        //    set
        //    {
        //        consumptionMPK = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        //[NotMapped]
        //public EmptyParamData TubesKZP
        //{
        //    get => tubesKZP; 
        //    set
        //    {
        //        tubesKZP = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        //[NotMapped]
        //public EmptyParamData ProcessKZU
        //{
        //    get => processKZU; 
        //    set
        //    {
        //        processKZU = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        //[NotMapped]
        //public EmptyParamData RollWidth
        //{
        //    get => rollWidth;
        //    set
        //    {
        //        rollWidth = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        //[NotMapped]
        //public EmptyParamData RollDiameter
        //{
        //    get => rollDiameter;
        //    set
        //    {
        //        rollDiameter = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        //[NotMapped]
        //public EmptyParamData DateInfo
        //{
        //    get => dateInfo;
        //    set
        //    {
        //        dateInfo = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        */

        public override string ToString()
        {
            return NameThis;
        }
    }
}
