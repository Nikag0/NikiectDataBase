using INotifyChangedCustom;
using System;
using System.Collections.Generic;

namespace DBcontext
{
    public class ResultsCreepRuptureTests : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private GeneralDescriptTest generalDescript = new GeneralDescriptTest();
        private List<TableResultsCreepRuptureTests> tableResultsCreep = new List<TableResultsCreepRuptureTests>();


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

        public GeneralDescriptTest GeneralDescript
        {
            get => generalDescript;
            set
            {
                generalDescript = value;
                NotifyPropertyChanged();
            }
        }

        public List<TableResultsCreepRuptureTests> TableResultsCreep
        {
            get => tableResultsCreep;
            set
            {
                tableResultsCreep = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }

    }
}
