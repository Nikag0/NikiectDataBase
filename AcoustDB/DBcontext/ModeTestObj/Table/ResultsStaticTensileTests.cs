using INotifyChangedCustom;
using System;
using System.Collections.Generic;

namespace DBcontext
{
    public class ResultsStaticTensileTests : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private GeneralDescriptTest generalDescript = new GeneralDescriptTest();
        private List<TableResultsStaticTensileTests> tableResultsStatic = new List<TableResultsStaticTensileTests>();


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

        public List<TableResultsStaticTensileTests> TableResultsStatic
        {
            get => tableResultsStatic;
            set
            {
                tableResultsStatic = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }

    }
}
