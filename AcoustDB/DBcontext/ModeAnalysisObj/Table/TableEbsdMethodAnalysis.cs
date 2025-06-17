using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class TableEbsdMethodAnalysis : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private FileControlData fileMapOrient = new FileControlData();
        private FileControlData fileMapPhase = new FileControlData();
        private FileControlData fileDiagrPhase = new FileControlData();

        private double sampleNumber = 0;
        private double averageMisorValue = 0;
        private string grainSize = "";
        private string crystallTextureSize = "";
        private double bccUser = 0;
        private double fccUser = 0;


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

        public FileControlData FileMapOrient
        {
            get => fileMapOrient;
            set
            {
                fileMapOrient = value;
                NotifyPropertyChanged();
            }
        }
        public FileControlData FileMapPhase
        {
            get => fileMapPhase;
            set
            {
                fileMapPhase = value;
                NotifyPropertyChanged();
            }
        }
        public FileControlData FileDiagrPhase
        {
            get => fileDiagrPhase;
            set
            {
                fileDiagrPhase = value;
                NotifyPropertyChanged();
            }
        }

        public double SampleNumber
        {
            get => sampleNumber;
            set
            {
                sampleNumber = value;
                NotifyPropertyChanged();
            }
        }

        public double AverageMisorValue
        {
            get => averageMisorValue;
            set
            {
                averageMisorValue = value;
                NotifyPropertyChanged();
            }
        }
        public string GrainSize
        {
            get => grainSize;
            set
            {
                grainSize = value;
                NotifyPropertyChanged();
            }
        }
        public string CrystallTextureSize
        {
            get => crystallTextureSize;
            set
            {
                crystallTextureSize = value;
                NotifyPropertyChanged();
            }
        }
        public double BccUser
        {
            get => bccUser;
            set
            {
                bccUser = value;
                NotifyPropertyChanged();
            }
        }
        public double FccUser
        {
            get => fccUser;
            set
            {
                fccUser = value;
                NotifyPropertyChanged();
            }
        }


        public override string ToString()
        {
            return NameThis;
        }
    }
}
