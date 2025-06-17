using INotifyChangedCustom;
using System;
using System.Collections.Generic;

namespace DBcontext
{
    public class ResultImpactTest : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private GeneralDescriptTest generalDescript = new GeneralDescriptTest();
        private List<TableResultImpactTest> tableResultImpact = new List<TableResultImpactTest>();


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

        public List<TableResultImpactTest> TableResultImpact
        {
            get => tableResultImpact;
            set
            {
                tableResultImpact = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }

    }
}
