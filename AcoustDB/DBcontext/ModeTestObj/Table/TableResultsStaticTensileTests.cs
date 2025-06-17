using INotifyChangedCustom;
using Microsoft.Win32;
using System;
using System.IO;

namespace DBcontext
{
    public class TableResultsStaticTensileTests : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private FileControlData fileInfo = new FileControlData();
        private double specimenNumber = 0;
        private string directionCutting = "";
        private double dUser = 0;
        private double lUser = 0;
        private double yieldStrength = 0;
        private double ultimateStrength = 0;
        private double relativeElongation = 0;
        private double relativeReductionArea = 0;


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

        public FileControlData FileInfo
        {
            get => fileInfo;
            set
            {
                fileInfo = value;
                NotifyPropertyChanged();
            }
        }

        public double SpecimenNumber
        {
            get => specimenNumber;
            set
            {
                specimenNumber = value;
                NotifyPropertyChanged();
            }
        }
        public string DirectionCutting
        {
            get => directionCutting;
            set
            {
                directionCutting = value;
                NotifyPropertyChanged();
            }
        }
        public double DUser
        {
            get => dUser;
            set
            {
                dUser = value;
                NotifyPropertyChanged();
            }
        }
        public double LUser
        {
            get => lUser;
            set
            {
                lUser = value;
                NotifyPropertyChanged();
            }
        }
        public double YieldStrength
        {
            get => yieldStrength;
            set
            {
                yieldStrength = value;
                NotifyPropertyChanged();
            }
        }
        public double UltimateStrength
        {
            get => ultimateStrength;
            set
            {
                ultimateStrength = value;
                NotifyPropertyChanged();
            }
        }
        public double RelativeElongation
        {
            get => relativeElongation;
            set
            {
                relativeElongation = value;
                NotifyPropertyChanged();
            }
        }
        public double RelativeReductionArea
        {
            get => relativeReductionArea;
            set
            {
                relativeReductionArea = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }

    }
}
