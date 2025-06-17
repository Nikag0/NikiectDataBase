using ICommandForWpf;
using INotifyChangedCustom;
using ModelsClass;
using System.Windows.Input;
using System.IO;
using Microsoft.Win32;
using DBcontext;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System;

namespace ViewModels
{
    public class ProgrammGlobalFuncViewModel : INotifyChanged
    {
        public ProgrammGlobalFuncViewModel(ProgrammGlobalFunc device)
        {
            DeviceFunc = device;
            InitCommand();
        }

        private ProgrammGlobalFunc deviceFunc = new();

        private string newNameObjUser = "";
        private TableParticleShape selectTableParticleShape;
        private int curUsedGeneralDescript = 0;
        private int curUsedAnalysis = 0;
        private int curUsedControl = 0;
        private int curUsedAcoustTestMethResult = 0;
        private GeneralDescriptTest generalDescriptStage2 = new GeneralDescriptTest();


        public ICommand SaveNewObjUser { get; private set; }
        public ICommand AddNewObjUser { get; private set; }
        public ICommand AddTableParticleShape { get; private set; }

        public ICommand LoadQualityPassport { get; private set; }
        public ICommand LoadGraphStressStage2Low { get; private set; }
        public ICommand LoadGraphStressStage2High { get; private set; }
        public ICommand LoadMetallMicrostrAssess { get; private set; }
        public ICommand LoadMetallgrNonmetallic { get; private set; }
        public ICommand LoadMetallgrDeterSizeDefGraph { get; private set; }
        public ICommand LoadMetallgrDeterSizeDefImg { get; private set; }
        public ICommand LoadFileMapOrient { get; private set; }
        public ICommand LoadFileMapPhase { get; private set; }
        public ICommand LoadFileDiagrPhase { get; private set; }
        public ICommand LoadFileAScanDataUz { get; private set; }
        public ICommand LoadFileBScanDataUz { get; private set; }
        public ICommand LoadFileCScanDataUz { get; private set; }
        public ICommand LoadFileImgDataTomogr { get; private set; }
        public ICommand LoadFileImgDataAcoustTestMeth_0 { get; private set; }
        public ICommand LoadFileImgDataAcoustTestMeth_1 { get; private set; }
        public ICommand LoadFileImgDataAcoustTestMeth_2 { get; private set; }
        public ICommand LoadFileImgDataAcoustTestMeth_3 { get; private set; }
        public ICommand CalcParamStage2SkoAver { get; private set; }


        public ProgrammGlobalFunc DeviceFunc
        {
            get => deviceFunc;
            set
            {
                deviceFunc = value;
                NotifyPropertyChanged();
            }
        }

        public string NewNameObjUser
        {
            get => newNameObjUser;
            set
            {
                newNameObjUser = value;
                NotifyPropertyChanged();
            }
        }

        public TableParticleShape SelectTableParticleShape
        {
            get => selectTableParticleShape;
            set
            {
                selectTableParticleShape = value;
                NotifyPropertyChanged();
            }
        }

        public GeneralDescriptTest GeneralDescriptStage2
        {
            get => generalDescriptStage2;
            private set
            {
                generalDescriptStage2 = value;
                NotifyPropertyChanged();
            }
        }

        public int CurUsedGeneralDescript
        {
            get => curUsedGeneralDescript;
            set
            {
                curUsedGeneralDescript = value;
                switch (curUsedGeneralDescript)
                {
                    case 0:
                        GeneralDescriptStage2 = deviceFunc.ContextAcoustDB.AllStageObjUser.SelectedItem.DbSetStageTestObjView.ResultsStaticLowTemp.GeneralDescript;
                        break;
                    case 1:
                        GeneralDescriptStage2 = deviceFunc.ContextAcoustDB.AllStageObjUser.SelectedItem.DbSetStageTestObjView.ResultsStaticHighTemp.GeneralDescript;
                        break;
                    case 2:
                        GeneralDescriptStage2 = deviceFunc.ContextAcoustDB.AllStageObjUser.SelectedItem.DbSetStageTestObjView.ResultImpact.GeneralDescript;
                        break;
                    case 3:
                        GeneralDescriptStage2 = deviceFunc.ContextAcoustDB.AllStageObjUser.SelectedItem.DbSetStageTestObjView.ResultsCreep.GeneralDescript;
                        break;

                    default:
                        break;
                }
                NotifyPropertyChanged();
            }
        }


        public int CurUsedAnalysis
        {
            get => curUsedAnalysis;
            set
            {
                curUsedAnalysis = value;
                NotifyPropertyChanged();
            }
        }

        public int CurUsedControl
        {
            get => curUsedControl;
            set
            {
                curUsedControl = value;
                NotifyPropertyChanged();
            }
        }

        public int CurUsedAcoustTestMethResult
        {
            get => curUsedAcoustTestMethResult;
            set
            {
                curUsedAcoustTestMethResult = value;
                NotifyPropertyChanged();
            }
        }

        public void UpdateView()
        {
            GeneralDescriptStage2 = deviceFunc.ContextAcoustDB.AllStageObjUser.SelectedItem?.DbSetStageTestObjView.ResultsStaticLowTemp.GeneralDescript;
        }

        private void InitCommand()
        {
            SaveNewObjUser = new RelayCommand(p => deviceFunc.ContextAcoustDB.SaveCompletedObjUser());
            AddNewObjUser = new RelayCommand(p => deviceFunc.ContextAcoustDB.AddCompletedObjUser(new AllStageObj() { NameThis = NewNameObjUser }));

            AddTableParticleShape = new RelayCommand(p => deviceFunc.ContextAcoustDB.AddTableParticleShape(SelectTableParticleShape));

            LoadQualityPassport = new RelayCommand(p => LoadFile(p, @"Stage_1\FilePassport", "FilePass", typeof(QualityPassport), true));

            LoadGraphStressStage2Low = new RelayCommand(p => LoadFile(p, @"Stage_2\ResultsStaticLowTemp", "FileInfo", typeof(TableResultsStaticTensileTests), true));
            LoadGraphStressStage2High = new RelayCommand(p => LoadFile(p, @"Stage_2\ResultsStaticHighTemp", "FileInfo", typeof(TableResultsStaticTensileTests), true));

            LoadFileAScanDataUz = new RelayCommand(p => LoadFile(p, @"Stage_3\UltrasonicTestingMethod", "FileUser_0", typeof(ResultTestingParameters)));
            LoadFileBScanDataUz = new RelayCommand(p => LoadFile(p, @"Stage_3\UltrasonicTestingMethod", "FileUser_1", typeof(ResultTestingParameters)));
            LoadFileCScanDataUz = new RelayCommand(p => LoadFile(p, @"Stage_3\UltrasonicTestingMethod", "FileUser_2", typeof(ResultTestingParameters)));

            LoadFileImgDataTomogr = new RelayCommand(p => LoadFile(p, @"Stage_3\TomographicTestingMethod", "FileUser_0", typeof(ResultTestingParameters)));

            LoadFileImgDataAcoustTestMeth_0 = new RelayCommand(p => LoadFile(p, @"Stage_3\AcousticEmissionTestingMethod", "FileUser_0", typeof(ResultTestingParameters)));
            LoadFileImgDataAcoustTestMeth_1 = new RelayCommand(p => LoadFile(p, @"Stage_3\AcousticEmissionTestingMethod", "FileUser_1", typeof(ResultTestingParameters)));
            LoadFileImgDataAcoustTestMeth_2 = new RelayCommand(p => LoadFile(p, @"Stage_3\AcousticEmissionTestingMethod", "FileUser_2", typeof(ResultTestingParameters)));
            LoadFileImgDataAcoustTestMeth_3 = new RelayCommand(p => LoadFile(p, @"Stage_3\AcousticEmissionTestingMethod", "FileUser_3", typeof(ResultTestingParameters)));

            LoadMetallMicrostrAssess = new RelayCommand(p => LoadFile(p, @"Stage_4\MetallMicrostrAssess", "FileInfoImg", typeof(TableMetallMethMicrostr)));
            LoadMetallgrNonmetallic = new RelayCommand(p => LoadFile(p, @"Stage_4\MetallgrNonmetallic", "FileInfoImg", typeof(TableMetallgrMethodNonmetallic)));

            LoadMetallgrDeterSizeDefGraph = new RelayCommand(p => LoadFile(p, @"Stage_4\MetallgrDeterSizeDefGraph", "FileInfoGraph", typeof(TableMetallogrDeterminSizeDef)));
            LoadMetallgrDeterSizeDefImg = new RelayCommand(p => LoadFile(p, @"Stage_4\MetallgrDeterSizeDefImg", "FileInfoImg", typeof(TableMetallogrDeterminSizeDef)));

            LoadFileMapOrient = new RelayCommand(p => LoadFile(p, @"Stage_4\FileMapOrient", "FileMapOrient", typeof(TableEbsdMethodAnalysis)));
            LoadFileMapPhase = new RelayCommand(p => LoadFile(p, @"Stage_4\FileMapPhase", "FileMapPhase", typeof(TableEbsdMethodAnalysis)));
            LoadFileDiagrPhase = new RelayCommand(p => LoadFile(p, @"Stage_4\FileDiagrPhase", "FileDiagrPhase", typeof(TableEbsdMethodAnalysis)));

            CalcParamStage2SkoAver = new RelayCommand(p =>
            {
                switch (curUsedGeneralDescript)
                {
                    case 0:
                        deviceFunc.ContextAcoustDB.CalculateStatisticsStaticTensileTests(DeviceFunc.ContextAcoustDB.AllStageObjUser.SelectedItem.DbSetStageTestObjView.ResultsStaticLowTemp.TableResultsStatic, true);
                        break;
                    case 1:
                        deviceFunc.ContextAcoustDB.CalculateStatisticsStaticTensileTests(DeviceFunc.ContextAcoustDB.AllStageObjUser.SelectedItem.DbSetStageTestObjView.ResultsStaticHighTemp.TableResultsStatic, false);
                        break;
                    case 2:
                        deviceFunc.ContextAcoustDB.CalculateStatisticImpactTest(DeviceFunc.ContextAcoustDB.AllStageObjUser.SelectedItem.DbSetStageTestObjView.ResultImpact.TableResultImpact);
                        break;
                    case 3:
                        deviceFunc.ContextAcoustDB.CalculateStatisticsCreepRuptureTests(DeviceFunc.ContextAcoustDB.AllStageObjUser.SelectedItem.DbSetStageTestObjView.ResultsCreep.TableResultsCreep);
                        break;

                    default:
                        break;
                }
            });
        }

        private void LoadFile(object inObj, string stepPath, string property, Type dataType, bool isClear = false)
        {
            if (inObj is null || !dataType.IsInstanceOfType(inObj))
                return;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file";
            openFileDialog.Filter = "All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string destinationDirectory = @"C:\FileAcoustDB\" + stepPath;
                string selectedFilePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(selectedFilePath);
                string destinationFilePath = Path.Combine(destinationDirectory, fileName);

                PropertyInfo fileInfoProperty = dataType.GetProperty(property) ?? throw new InvalidOperationException($"Объект не содержит свойства: {property}");
                object fileInfoCollection = fileInfoProperty.GetValue(inObj);
                if (fileInfoCollection is not FileControlData fileInfoList)
                    throw new InvalidOperationException($"Объект не является: FileControlData");

                if (isClear)
                    fileInfoList.FileInfo.Clear();

                bool isExists = fileInfoList.FileInfo.Any(x => x.NameFile == fileName);
                if (!isExists)
                {
                    fileInfoList.AddData(new DescriptFile { NameFile = fileName, PathFile = destinationFilePath });
                }

                if (!Directory.Exists(destinationDirectory))
                {
                    Directory.CreateDirectory(destinationDirectory);
                }
                File.Copy(selectedFilePath, destinationFilePath, true);
            }
        }
    }
}
