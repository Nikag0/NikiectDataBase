using INotifyChangedCustom;
using System;
using System.Collections.Generic;

namespace DBcontext
{
    public class TableMetallMethMicrostr : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private FileControlData fileInfoImg = new FileControlData();

        private double sampleNumber = 0;
        private double scaleMicrostructureDescription = 0;
        private double ball = 0;
        private double row = 0;
        private double scaleMicrostructureAssessment = 0;
        private double ball1 = 0;
        private double row1 = 0;

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
        public double ScaleMicrostructureDescription
        {
            get => scaleMicrostructureDescription;
            set
            {
                scaleMicrostructureDescription = value;
                NotifyPropertyChanged();
            }
        }
        public double Ball
        {
            get => ball;
            set
            {
                ball = value;
                NotifyPropertyChanged();
            }
        }
        public double Row
        {
            get => row;
            set
            {
                row = value;
                NotifyPropertyChanged();
            }
        }
        public double ScaleMicrostructureAssessment
        {
            get => scaleMicrostructureAssessment;
            set
            {
                scaleMicrostructureAssessment = value;
                NotifyPropertyChanged();
            }
        }
        public double Ball1
        {
            get => ball1;
            set
            {
                ball1 = value;
                NotifyPropertyChanged();
            }
        }
        public double Row1
        {
            get => row1;
            set
            {
                row1 = value;
                NotifyPropertyChanged();
            }
        }

       

        public override string ToString()
        {
            return NameThis;
        }

    }
}
