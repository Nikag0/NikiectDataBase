using INotifyChangedCustom;
using System;
using System.Collections.Generic;

namespace DBcontext
{
    public class StageAnalysisObj : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private List<TableMetallMethMicrostr> tableMetallMethMicrostr = new List<TableMetallMethMicrostr>();
        private List<TableMicrohardnessMeasur> tableMicrohardMeasur = new List<TableMicrohardnessMeasur>();
        private List<TableMetallgrMethodNonmetallic> tableMetallgrNonmetallic = new List<TableMetallgrMethodNonmetallic>();
        private List<TableMetallogrDeterminSizeDef> tableMetallDeterSizeDef = new List<TableMetallogrDeterminSizeDef>();
        private List<TableEbsdMethodAnalysis> tableEbsdMicrostrAnalysis = new List<TableEbsdMethodAnalysis>();


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

        public List<TableMetallMethMicrostr> TableMetallMethMicrostr
        {
            get => tableMetallMethMicrostr;
            set
            {
                tableMetallMethMicrostr = value;
                NotifyPropertyChanged();
            }
        }

        public List<TableMicrohardnessMeasur> TableMicrohardMeasur
        {
            get => tableMicrohardMeasur;
            set
            {
                tableMicrohardMeasur = value;
                NotifyPropertyChanged();
            }
        }

        public List<TableMetallgrMethodNonmetallic> TableMetallgrNonmetallic
        {
            get => tableMetallgrNonmetallic;
            set
            {
                tableMetallgrNonmetallic = value;
                NotifyPropertyChanged();
            }
        }

        public List<TableMetallogrDeterminSizeDef> TableMetallDeterSizeDef
        {
            get => tableMetallDeterSizeDef;
            set
            {
                tableMetallDeterSizeDef = value;
                NotifyPropertyChanged();
            }
        }

        public List<TableEbsdMethodAnalysis> TableEbsdMicrostrAnalysis
        {
            get => tableEbsdMicrostrAnalysis;
            set
            {
                tableEbsdMicrostrAnalysis = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }



    }
}
