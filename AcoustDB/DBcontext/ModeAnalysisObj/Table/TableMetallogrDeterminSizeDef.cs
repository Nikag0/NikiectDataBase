using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class TableMetallogrDeterminSizeDef : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private FileControlData fileInfoImg = new FileControlData();
        private FileControlData fileInfoGraph = new FileControlData();

        private double sampleNumber = 0;
        private double degreePorosity = 0;
        private double maximumPoreSize = 0;
        private double lackFusion = 0;
        private double layerDisplacements = 0;
        private double cracks = 0;
        private double inclusions = 0;
        private double others = 0;


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

        public FileControlData FileInfoGraph
        {
            get => fileInfoGraph;
            set
            {
                fileInfoGraph = value;
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

        public double DegreePorosity
        {
            get => degreePorosity;
            set
            {
                degreePorosity = value;
                NotifyPropertyChanged();
            }
        }
        public double MaximumPoreSize
        {
            get => maximumPoreSize;
            set
            {
                maximumPoreSize = value;
                NotifyPropertyChanged();
            }
        }
        public double LackFusion
        {
            get => lackFusion; 
            set
            {
                lackFusion = value;
                NotifyPropertyChanged();
            }
        }
        public double LayerDisplacements
        {
            get => layerDisplacements; 
            set
            {
                layerDisplacements = value;
                NotifyPropertyChanged();
            }
        }
        public double Cracks
        {
            get => cracks; 
            set
            {
                cracks = value;
                NotifyPropertyChanged();
            }
        }
        public double Inclusions
        {
            get => inclusions; 
            set
            {
                inclusions = value;
                NotifyPropertyChanged();
            }
        }
        public double Others
        {
            get => others;
            set
            {
                others = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
