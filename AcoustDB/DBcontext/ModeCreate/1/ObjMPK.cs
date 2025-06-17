using AcoustDB.DBcontext.ModeCreate._1;
using DocumentFormat.OpenXml.Office2010.Excel;
using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBcontext
{
    public class ObjMPK : INotifyChanged
    {
        private ObservableCollection<TableParticleShape> tableParticleShape = new ObservableCollection<TableParticleShape>();
        private ObservableCollection<TableParticleShapeMPK> tableParticleShapeMPK = new ObservableCollection<TableParticleShapeMPK>();
        private List<TableChemicalCompositMPK> compositMPKs = new List<TableChemicalCompositMPK>();

        [NotMapped]
        public ObservableCollection<TableParticleShape> TableParticleShape
        {
            get => tableParticleShape;
            set
            {
                tableParticleShape = value;
                NotifyPropertyChanged();
            }
        }
        [NotMapped]
        public ObservableCollection<TableParticleShapeMPK> TableParticleShapeMPK
        {
            get => tableParticleShapeMPK;
            set
            {
                tableParticleShapeMPK = value;
                NotifyPropertyChanged();
            }
        }

        [NotMapped]
        public List<TableChemicalCompositMPK> CompositMPKs
        {
            get => compositMPKs;
            set
            {
                compositMPKs = value;
                NotifyPropertyChanged();
            }
        }




        private Guid id = Guid.NewGuid();
        private string nameThis = "";
        private Guid idTableBasicInfoMPK;
        private Guid idTableTechnCharcsMPK;
        private Guid idPassport;

        private QualityPassport passport = new QualityPassport();
        private TableBasicInfoMPK basicInfoMPK = new TableBasicInfoMPK();
        private TableTechnCharcsMPK technCharcsMPK = new TableTechnCharcsMPK();


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
        public Guid IdTableBasicInfoMPK
        {
            get => idTableBasicInfoMPK;
            set
            {
                idTableBasicInfoMPK = value;
                NotifyPropertyChanged();
            }
        }
        public Guid IdTableTechnCharcsMPK
        {
            get => idTableTechnCharcsMPK;
            set
            {
                idTableTechnCharcsMPK = value;
                NotifyPropertyChanged();
            }
        }
        public Guid IdPassport
        {
            get => idPassport;
            set
            {
                idPassport = value;
                NotifyPropertyChanged();
            }
        }

        [NotMapped]
        public QualityPassport Passport
        {
            get => passport;
            set
            {
                passport = value;
                NotifyPropertyChanged();
            }
        }
        [NotMapped]
        public TableBasicInfoMPK BasicInfoMPK
        {
            get => basicInfoMPK;
            set
            {
                basicInfoMPK = value;
                NotifyPropertyChanged();
            }
        }
        [NotMapped]
        public TableTechnCharcsMPK TechnCharcsMPK
        {
            get => technCharcsMPK;
            set
            {
                technCharcsMPK = value;
                NotifyPropertyChanged();
            }
        }
        public override string ToString()
        {
            return NameThis;
        }
    }
}
