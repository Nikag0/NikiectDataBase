using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DBcontext
{
    public class StageTestObjView : INotifyChanged
    {
        public StageTestObjView()
        {

        }


        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private ResultsStaticTensileTests resultsStaticLowTemp = new ResultsStaticTensileTests();
        private ResultsStaticTensileTests resultsStaticHighTemp = new ResultsStaticTensileTests();
        private ResultImpactTest resultImpact = new ResultImpactTest();
        private ResultsCreepRuptureTests resultsCreep = new ResultsCreepRuptureTests();

        private StatisticsResultsStage2 statisticsResults = new StatisticsResultsStage2();


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

        public ResultsStaticTensileTests ResultsStaticLowTemp
        {
            get => resultsStaticLowTemp;
            set
            {
                resultsStaticLowTemp = value;
                NotifyPropertyChanged();
            }
        }
        public ResultsStaticTensileTests ResultsStaticHighTemp
        {
            get => resultsStaticHighTemp;
            set
            {
                resultsStaticHighTemp = value;
                NotifyPropertyChanged();
            }
        }
        public ResultImpactTest ResultImpact
        {
            get => resultImpact;
            set
            {
                resultImpact = value;
                NotifyPropertyChanged();
            }
        }
        public ResultsCreepRuptureTests ResultsCreep
        {
            get => resultsCreep;
            set
            {
                resultsCreep = value;
                NotifyPropertyChanged();
            }
        }

        public StatisticsResultsStage2 StatisticsResults
        {
            get => statisticsResults;
            set
            {
                statisticsResults = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
