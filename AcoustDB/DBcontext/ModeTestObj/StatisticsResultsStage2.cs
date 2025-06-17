using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBcontext
{
    public class StatisticsResultsStage2 : INotifyChanged
    {
        private StatisticsResult yieldStrengthLow = new StatisticsResult();
        private StatisticsResult ultimateStrengthLow = new StatisticsResult();
        private StatisticsResult relativeElongationLow = new StatisticsResult();
        private StatisticsResult relativeReductionAreaLow = new StatisticsResult();

        private StatisticsResult yieldStrength = new StatisticsResult();
        private StatisticsResult ultimateStrength = new StatisticsResult();
        private StatisticsResult relativeElongation = new StatisticsResult();
        private StatisticsResult relativeReductionArea = new StatisticsResult();

        private StatisticsResult crossSectionalArea = new StatisticsResult();
        private StatisticsResult impactStrength = new StatisticsResult();

        private StatisticsResult stress = new StatisticsResult();
        private StatisticsResult testDurationBeforeFailure = new StatisticsResult();
        private StatisticsResult relativeElongation_1 = new StatisticsResult();
        private StatisticsResult relativeReductionArea_1 = new StatisticsResult();

        public StatisticsResult YieldStrength
        {
            get => yieldStrength;
            set
            {
                yieldStrength = value;
                NotifyPropertyChanged();
            }
        }
        public StatisticsResult UltimateStrength
        {
            get => ultimateStrength;
            set
            {
                ultimateStrength = value;
                NotifyPropertyChanged();
            }
        }
        public StatisticsResult RelativeElongation
        {
            get => relativeElongation; set
            {
                relativeElongation = value;
                NotifyPropertyChanged();
            }
        }
        public StatisticsResult RelativeReductionArea
        {
            get => relativeReductionArea; set
            {
                relativeReductionArea = value;
                NotifyPropertyChanged();
            }
        }
        public StatisticsResult CrossSectionalArea
        {
            get => crossSectionalArea; set
            {
                crossSectionalArea = value;
                NotifyPropertyChanged();
            }
        }
        public StatisticsResult ImpactStrength
        {
            get => impactStrength; set
            {
                impactStrength = value;
                NotifyPropertyChanged();
            }
        }
        public StatisticsResult Stress
        {
            get => stress; set
            {
                stress = value;
                NotifyPropertyChanged();
            }
        }
        public StatisticsResult TestDurationBeforeFailure
        {
            get => testDurationBeforeFailure; set
            {
                testDurationBeforeFailure = value;
                NotifyPropertyChanged();
            }
        }
        public StatisticsResult RelativeElongation_1
        {
            get => relativeElongation_1; set
            {
                relativeElongation_1 = value;
                NotifyPropertyChanged();
            }
        }
        public StatisticsResult RelativeReductionArea_1
        {
            get => relativeReductionArea_1; set
            {
                relativeReductionArea_1 = value;
                NotifyPropertyChanged();
            }
        }

        public StatisticsResult YieldStrengthLow
        {
            get => yieldStrengthLow;
            set
            {
                yieldStrengthLow = value;
                NotifyPropertyChanged();
            }
        }
        public StatisticsResult UltimateStrengthLow
        {
            get => ultimateStrengthLow;
            set
            {
                ultimateStrengthLow = value;
                NotifyPropertyChanged();
            }
        }
        public StatisticsResult RelativeElongationLow
        {
            get => relativeElongationLow; set
            {
                relativeElongationLow = value;
                NotifyPropertyChanged();
            }
        }
        public StatisticsResult RelativeReductionAreaLow
        {
            get => relativeReductionAreaLow; set
            {
                relativeReductionAreaLow = value;
                NotifyPropertyChanged();
            }
        }
    }
}
