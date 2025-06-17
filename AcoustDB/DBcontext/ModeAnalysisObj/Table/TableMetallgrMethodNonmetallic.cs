using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class TableMetallgrMethodNonmetallic : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private FileControlData fileInfoImg = new FileControlData();

        private double sampleNumber = 0;
        private string methodUser = "";
        private double maximumScoreInclusions = 0;
        private double lineOxides = 0;
        private double pointOxides = 0;
        private double brittleSilicates = 0;
        private double plasticSilicates = 0;
        private double nonDeformableSilicates = 0;
        private double sulfides = 0;
        private double lineNitridesCarbonitrides = 0;
        private double pointNitridesCarbonitrides = 0;
        private double aluminumNitrides = 0;
        private double other = 0;




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

        public FileControlData FileInfoImg
        {
            get => fileInfoImg;
            set
            {
                fileInfoImg = value;
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

        public string MethodUser
        {
            get => methodUser;
            set
            {
                methodUser = value;
                NotifyPropertyChanged();
            }
        }
        public double MaximumScoreInclusions
        {
            get => maximumScoreInclusions;
            set
            {
                maximumScoreInclusions = value;
                NotifyPropertyChanged();
            }
        }
        public double LineOxides
        {
            get => lineOxides;
            set
            {
                lineOxides = value;
                NotifyPropertyChanged();
            }
        }
        public double PointOxides
        {
            get => pointOxides;
            set
            {
                pointOxides = value;
                NotifyPropertyChanged();
            }
        }
        public double BrittleSilicates
        {
            get => brittleSilicates;
            set
            {
                brittleSilicates = value;
                NotifyPropertyChanged();
            }
        }
        public double PlasticSilicates
        {
            get => plasticSilicates;
            set
            {
                plasticSilicates = value;
                NotifyPropertyChanged();
            }
        }
        public double NonDeformableSilicates
        {
            get => nonDeformableSilicates;
            set
            {
                nonDeformableSilicates = value;
                NotifyPropertyChanged();
            }
        }
        public double Sulfides
        {
            get => sulfides;
            set
            {
                sulfides = value;
                NotifyPropertyChanged();
            }
        }
        public double LineNitridesCarbonitrides
        {
            get => lineNitridesCarbonitrides;
            set
            {
                lineNitridesCarbonitrides = value;
                NotifyPropertyChanged();
            }
        }
        public double PointNitridesCarbonitrides
        {
            get => pointNitridesCarbonitrides;
            set
            {
                pointNitridesCarbonitrides = value;
                NotifyPropertyChanged();
            }
        }
        public double AluminumNitrides
        {
            get => aluminumNitrides;
            set
            {
                aluminumNitrides = value;
                NotifyPropertyChanged();
            }
        }
        public double Other
        {
            get => other;
            set
            {
                other = value;
                NotifyPropertyChanged();
            }
        }
    }
}
