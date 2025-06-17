using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class TableResultsCreepRuptureTests : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private double specimenNumber = 0;
        private string directionCutting = "";
        private double dBefore = 0;
        private double lBefore = 0;
        private double dAfter = 0;
        private double lAfter = 0;
        private double stress = 0;
        private double testDurationBeforeFailure = 0;
        private double relativeElongation = 0;
        private double relativeReductionArea = 0;
        private string noteUSer = "";

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

        public double DBefore
        {
            get => dBefore;
            set
            {
                dBefore = value;
                NotifyPropertyChanged();
            }
        }
        public double LBefore
        {
            get => lBefore;
            set
            {
                lBefore = value;
                NotifyPropertyChanged();
            }
        }
        public double DAfter
        {
            get => dAfter;
            set
            {
                dAfter = value;
                NotifyPropertyChanged();
            }
        }
        public double LAfter
        {
            get => lAfter;
            set
            {
                lAfter = value;
                NotifyPropertyChanged();
            }
        }
        public double Stress
        {
            get => stress;
            set
            {
                stress = value;
                NotifyPropertyChanged();
            }
        }
        public double TestDurationBeforeFailure
        {
            get => testDurationBeforeFailure;
            set
            {
                testDurationBeforeFailure = value;
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
        public string NoteUSer
        {
            get => noteUSer;
            set
            {
                noteUSer = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }

    }
}
