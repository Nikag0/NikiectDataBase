using INotifyChangedCustom;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBcontext
{
    public class AllStageObj : INotifyChanged
    {
        public AllStageObj()
        {
            
        }

        private Guid id = Guid.NewGuid();
        private DateTime dateRelease = DateTime.Now;
        private string nameThis = "";

        private StageManufact dbSetStageManufact = new StageManufact();
        private StageTestObjView dbSetStageTestObjView = new StageTestObjView();
        private StageNonDestructiveTesting dbSetStageNonDestructive = new StageNonDestructiveTesting();
        private StageAnalysisObj dbSetStageAnalysisObj = new StageAnalysisObj();
        [Key]
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
        public DateTime DataRelease
        {
            get => dateRelease;
            set
            {
                dateRelease = value;
                NotifyPropertyChanged();
            }
        }
        [NotMapped]
        public StageManufact DbSetStageManufact
        {
            get => dbSetStageManufact;
            set
            {
                dbSetStageManufact = value;
                NotifyPropertyChanged();
            }
        }
        [NotMapped]
        public StageTestObjView DbSetStageTestObjView
        {
            get => dbSetStageTestObjView;
            set
            {
                dbSetStageTestObjView = value;
                NotifyPropertyChanged();
            }
        }
        [NotMapped]
        public StageAnalysisObj DbSetStageAnalysisObj
        {
            get => dbSetStageAnalysisObj;
            set
            {
                dbSetStageAnalysisObj = value;
                NotifyPropertyChanged();
            }
        }
        [NotMapped]
        public StageNonDestructiveTesting DbSetStageNonDestructive
        {
            get => dbSetStageNonDestructive;
            set
            {
                dbSetStageNonDestructive = value;
                NotifyPropertyChanged();
            }
        }
    }
}
