using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class TableResultImpactTest : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private double specimenNumber = 0;
        private string directionCutting = "";
        private double specimenWidth = 0;
        private double specimenHeight = 0;
        private double heightWorkingSection = 0;
        private double crossSectionalArea = 0; // calc
        private double impactWork = 0;
        private double impactStrength = 0; // calc
        private string noteUser = "";



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

        public double SpecimenWidth
        {
            get => specimenWidth;
            set
            {
                specimenWidth = value;
                CalcCrossSectionalArea();
                NotifyPropertyChanged();
            }
        }
        public double SpecimenHeight
        {
            get => specimenHeight;
            set
            {
                specimenHeight = value;
                NotifyPropertyChanged();
            }
        }
        public double HeightWorkingSection
        {
            get => heightWorkingSection;
            set
            {
                heightWorkingSection = value;
                CalcCrossSectionalArea();
                NotifyPropertyChanged();
            }
        }
        public double CrossSectionalArea
        {
            get => crossSectionalArea;
            set
            {
                crossSectionalArea = value;
                CalcImpactStrength();
                NotifyPropertyChanged();
            }
        }
        public double ImpactWork
        {
            get => impactWork;
            set
            {
                impactWork = value;
                CalcImpactStrength();
                NotifyPropertyChanged();
            }
        }
        public double ImpactStrength
        {
            get => impactStrength;
            set
            {
                impactStrength = value;
                NotifyPropertyChanged();
            }
        }
        public string NoteUser
        {
            get => noteUser;
            set
            {
                noteUser = value;
                NotifyPropertyChanged();
            }
        }

        private void CalcCrossSectionalArea()
        {
            CrossSectionalArea = specimenWidth * heightWorkingSection / 100;
        }

        private void CalcImpactStrength()
        {
            if (crossSectionalArea > 0)
            {
                ImpactStrength = impactWork / crossSectionalArea;
            }
        }

        public override string ToString()
        {
            return NameThis;
        }

    }
}
