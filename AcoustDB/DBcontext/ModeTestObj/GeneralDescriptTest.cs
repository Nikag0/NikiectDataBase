using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class GeneralDescriptTest : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private bool isEnable = false;
        private string testPerformer = "";
        private string testObject = "";
        private string testType = "";
        private string environment = "";
        private string specialTestConditions = "";
        private string regulatoryDocumentation = "";
        private string testSamples = "";
        private string sampleNumber = "";
        private string usedMeasurInstrument = "";


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

        public bool IsEnable
        {
            get => isEnable;
            set
            {
                isEnable = value;
                NotifyPropertyChanged();
            }
        }

        public string TestPerformer
        {
            get => testPerformer;
            set
            {
                testPerformer = value;
                NotifyPropertyChanged();
            }
        }
        public string TestObject
        {
            get => testObject;
            set
            {
                testObject = value;
                NotifyPropertyChanged();
            }
        }
        public string TestType
        {
            get => testType;
            set
            {
                testType = value;
                NotifyPropertyChanged();
            }
        }
        public string Environment
        {
            get => environment;
            set
            {
                environment = value;
                NotifyPropertyChanged();
            }
        }
        public string SpecialTestConditions
        {
            get => specialTestConditions;
            set
            {
                specialTestConditions = value;
                NotifyPropertyChanged();
            }
        }
        public string RegulatoryDocumentation
        {
            get => regulatoryDocumentation;
            set
            {
                regulatoryDocumentation = value;
                NotifyPropertyChanged();
            }
        }
        public string TestSamples
        {
            get => testSamples;
            set
            {
                testSamples = value;
                NotifyPropertyChanged();
            }
        }
        public string SampleNumber
        {
            get => sampleNumber;
            set
            {
                sampleNumber = value;
                NotifyPropertyChanged();
            }
        }
        public string UsedMeasurInstrument
        {
            get => usedMeasurInstrument;
            set
            {
                usedMeasurInstrument = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
