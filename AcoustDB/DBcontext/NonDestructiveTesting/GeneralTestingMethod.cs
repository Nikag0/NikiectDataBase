using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DBcontext
{
    public class GeneralTestingMethod : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";
        private GeneralMethodData generalDataTesting = new GeneralMethodData();
        private List<GeneralTestingParameters> tableTestingTools = new List<GeneralTestingParameters>();
        private List<GeneralTestingParameters> tableEquipmentParameters = new List<GeneralTestingParameters>();
        private List<GeneralTestingParameters> tableTestingParameters = new List<GeneralTestingParameters>();
        private List<ResultTestingParameters> tableTestingResults = new List<ResultTestingParameters>();


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

        public GeneralMethodData GeneralDataTesting
        {
            get => generalDataTesting;
            set
            {
                generalDataTesting = value;
                NotifyPropertyChanged();
            }
        }
        public List<GeneralTestingParameters> TableTestingTools
        {
            get => tableTestingTools;
            set
            {
                tableTestingTools = value;
                NotifyPropertyChanged();
            }
        }
        public List<GeneralTestingParameters> TableEquipmentParameters
        {
            get => tableEquipmentParameters; 
            set
            {
                tableEquipmentParameters = value;
                NotifyPropertyChanged();
            }
        }
        public List<GeneralTestingParameters> TableTestingParameters
        {
            get => tableTestingParameters;
            set
            {
                tableTestingParameters = value;
                NotifyPropertyChanged();
            }
        }
        public List<ResultTestingParameters> TableTestingResults
        {
            get => tableTestingResults; 
            set
            {
                tableTestingResults = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
