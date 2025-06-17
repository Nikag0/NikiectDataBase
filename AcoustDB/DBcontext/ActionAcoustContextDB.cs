using INotifyChangedCustom;
using SaveConfigObject;
using SerializationObject;
using System.Collections.Generic;
using System;
using System.Linq;
using Npgsql;
using System.Windows.Input;
using DocumentFormat.OpenXml.Office2010.Excel;
using System.Windows.Controls.Primitives;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections;
using NpgsqlTypes;
using DocumentFormat.OpenXml.Drawing.Charts;
using AcoustDB.DBcontext;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows;
using AcoustDB.DBcontext.ModeCreate._1;

namespace DBcontext
{
    public class ActionAcoustContextDB : INotifyChanged
    {
        private ObservableCollection<TableParticleShape> collectionParticleShape = new ObservableCollection<TableParticleShape>();
        public ObservableCollection<TableParticleShape> CollectionParticleShape
        {
            get => collectionParticleShape;
            set
            {
                collectionParticleShape = value;
                NotifyPropertyChanged();
            }
        }





        private Settings<SerializAcoustContextDB> serializAcoustContext = new Settings<SerializAcoustContextDB>();
        private Settings<SerializCompletedData> serializCompletedDataUser = new Settings<SerializCompletedData>();
        private AcoustContextDB acoustContextDb = new AcoustContextDB();
        private ListCompletedDataObserv allStageObjUser = new ListCompletedDataObserv();
        private NpgsqlConnection connection;
        private ApplicationContext db = new ApplicationContext();
        private ObservableCollection<TableBasicInfoMPK> collectionBasicInfoMPK = new ObservableCollection<TableBasicInfoMPK>();
        private ObservableCollection<TableTechnCharcsMPK> collectionTechnCharcsMPK = new ObservableCollection<TableTechnCharcsMPK>();

        public AcoustContextDB AcoustContextDb
        {
            get => acoustContextDb;
            set
            {
                acoustContextDb = value;
                NotifyPropertyChanged();
            }
        }
        public ListCompletedDataObserv AllStageObjUser
        {
            get => allStageObjUser;
            set
            {
                allStageObjUser = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<TableBasicInfoMPK> CollectionBasicInfoMPK
        {
            get => collectionBasicInfoMPK;
            set
            {
                collectionBasicInfoMPK = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<TableTechnCharcsMPK> CollectionTechnCharcsMPK
        {
            get => collectionTechnCharcsMPK;
            set
            {
                collectionTechnCharcsMPK = value;
                NotifyPropertyChanged();
            }
        }

        public bool AddCompletedObjUser(AllStageObj completedTransactions)
        {
            if (!string.IsNullOrEmpty(completedTransactions.NameThis))
            {
                AllStageObjUser.AddNewItem(SerializationObjectStatic.SerializationObjectForCopy(completedTransactions));
                return true;
            }

            return false;
        }

        public bool AddTableParticleShape (TableParticleShape shape)
        {
            if (!string.IsNullOrEmpty(shape.NameThis) && !AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.TableParticleShape.Contains(shape))
            {
                AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.TableParticleShape.Add(shape);
                //TableParticleShapeMPK newtableParticleShapeMPK = new TableParticleShapeMPK
                //{
                //    IdObjMPK = AllStageObjUser.SelectedItem.DbSetStageManufact.IdObjMPK,
                //    IdTableParticleShape = shape.Id
                //};
                //db.TableParticleShapeMPK.Add(newtableParticleShapeMPK);
                //db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool SaveCompletedObjUser()
        {
            db.AllStageObj.Add(AllStageObjUser.SelectedItem);
            db.MarkMPK.Add(AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.BasicInfoMPK.MarkMPK);
            foreach (var item in AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.TableParticleShapeMPK)
            {
                db.TableParticleShapeMPK.Add(item);
            }

            int affectedRows = db.SaveChanges();
            db.TableTechnCharcsMPK.Add(AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.TechnCharcsMPK);
            AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.BasicInfoMPK.IdMarkMPK = AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.BasicInfoMPK.MarkMPK.Id;
            db.TableBasicInfoMPK.Add(AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.BasicInfoMPK);
            db.QualityPassport.Add(AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.Passport);
            affectedRows = db.SaveChanges();
            AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.IdTableBasicInfoMPK = AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.BasicInfoMPK.Id;
            AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.IdTableTechnCharcsMPK = AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.TechnCharcsMPK.Id;
            AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.IdPassport = AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.Passport.Id;
            //AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.ParticleShapeData.Shape = AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.ParticleShapeData.Shape.Id;
            db.ObjMPK.Add(AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK);
            affectedRows = db.SaveChanges();
            AllStageObjUser.SelectedItem.DbSetStageManufact.IdObjMPK = AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.Id;
            AllStageObjUser.SelectedItem.DbSetStageManufact.IdAllStageObj = AllStageObjUser.SelectedItem.Id;
            db.StageManufact.Add(AllStageObjUser.SelectedItem.DbSetStageManufact);
            affectedRows = db.SaveChanges();
            return true;
        }

        public void LoadCatalog()
        {
            AllStageObjUser.Collection.Clear();

            foreach (AllStageObj item in db.AllStageObj)    
            {
                AllStageObjUser.Collection.Add(item);
            }

            foreach (TableBasicInfoMPK item in db.TableBasicInfoMPK)
            {
                CollectionBasicInfoMPK.Add(item);
            }            
            
            foreach (TableTechnCharcsMPK item in db.TableTechnCharcsMPK)
            {
                CollectionTechnCharcsMPK.Add(item);
            }

            foreach (TableParticleShape item in db.TableParticleShape)
            {
                CollectionParticleShape.Add(item);
            }

            foreach (AllStageObj stageObj in AllStageObjUser.Collection)
            {
                stageObj.DbSetStageManufact = db.StageManufact.FirstOrDefault(sm => sm.IdAllStageObj == stageObj.Id);
                stageObj.DbSetStageManufact.DbObjMPK = db.ObjMPK.FirstOrDefault(sm => sm.Id == stageObj.DbSetStageManufact.IdObjMPK);


                foreach (TableParticleShapeMPK item in db.TableParticleShapeMPK)
                {
                    if (stageObj.DbSetStageManufact.DbObjMPK.Id == item.IdObjMPK)
                    {
                        stageObj.DbSetStageManufact.DbObjMPK.TableParticleShapeMPK.Add(item);
                    }
                }

                foreach (TableParticleShapeMPK item in stageObj.DbSetStageManufact.DbObjMPK.TableParticleShapeMPK)
                {
                    foreach (TableParticleShape item1 in db.TableParticleShape)
                    {
                        if (item.IdTableParticleShape == item1.Id)
                        {
                            stageObj.DbSetStageManufact.DbObjMPK.TableParticleShape.Add(item1);
                        }
                    }
                }

                foreach (ParticleShape item in db.ParticleShape)
                {
                    foreach (TableParticleShape item1 in stageObj.DbSetStageManufact.DbObjMPK.TableParticleShape)
                    {
                        if (item.Id == item1.IdParticleShape)
                        {
                            item1.Shape = item;
                        }
                    }
                }

                stageObj.DbSetStageManufact.DbObjMPK.Passport = db.QualityPassport.FirstOrDefault(sm => sm.Id == stageObj.DbSetStageManufact.DbObjMPK.IdPassport);
                stageObj.DbSetStageManufact.DbObjMPK.BasicInfoMPK = db.TableBasicInfoMPK.FirstOrDefault(sm => sm.Id == stageObj.DbSetStageManufact.DbObjMPK.IdTableBasicInfoMPK);
                stageObj.DbSetStageManufact.DbObjMPK.BasicInfoMPK.MarkMPK = db.MarkMPK.FirstOrDefault(sm => sm.Id == stageObj.DbSetStageManufact.DbObjMPK.BasicInfoMPK.IdMarkMPK);
                stageObj.DbSetStageManufact.DbObjMPK.TechnCharcsMPK = db.TableTechnCharcsMPK.FirstOrDefault(sm => sm.Id == stageObj.DbSetStageManufact.DbObjMPK.IdTableTechnCharcsMPK);
            }

            //foreach (TableParticleShape item in db.TableParticleShape)
            //{
            //    AllStageObjUser.Collection.
            //}
        }

        public void SaveCatalog()
        {
            serializAcoustContext.AppData.FileName = "ConfigAcoustContext.xml";
            serializAcoustContext.AppData.SAcoustContextDB = AcoustContextDb;
            serializAcoustContext.Save();

            serializCompletedDataUser.AppData.FileName = "ConfigCompletedDataUser.xml";
            serializCompletedDataUser.AppData.SAllStageObj = AllStageObjUser.Collection.ToList();
            serializCompletedDataUser.Save();
        }

        public void CalculateStatisticsStaticTensileTests(List<TableResultsStaticTensileTests> results, bool isLowTemp)
        {
            Dictionary<string, double[]> values = new Dictionary<string, double[]>();

            if (isLowTemp)
            {
                values = new Dictionary<string, double[]>
                {
                    ["YieldStrengthLow"] = results.Select(r => r.YieldStrength).ToArray(),
                    ["UltimateStrengthLow"] = results.Select(r => r.UltimateStrength).ToArray(),
                    ["RelativeElongationLow"] = results.Select(r => r.RelativeElongation).ToArray(),
                    ["RelativeReductionAreaLow"] = results.Select(r => r.RelativeReductionArea).ToArray()
                };
            }
            else
            {
                values = new Dictionary<string, double[]>
                {
                    ["YieldStrength"] = results.Select(r => r.YieldStrength).ToArray(),
                    ["UltimateStrength"] = results.Select(r => r.UltimateStrength).ToArray(),
                    ["RelativeElongation"] = results.Select(r => r.RelativeElongation).ToArray(),
                    ["RelativeReductionArea"] = results.Select(r => r.RelativeReductionArea).ToArray()
                };
            }

            CalculateStatistics(values);
        }

        public void CalculateStatisticImpactTest(List<TableResultImpactTest> results)
        {
            Dictionary<string, double[]> values = new Dictionary<string, double[]>
            {
                ["CrossSectionalArea"] = results.Select(r => r.CrossSectionalArea).ToArray(),
                ["ImpactStrength"] = results.Select(r => r.ImpactStrength).ToArray(),
            };

            CalculateStatistics(values);
        }

        public void CalculateStatisticsCreepRuptureTests(List<TableResultsCreepRuptureTests> results)
        {
            Dictionary<string, double[]> values = new Dictionary<string, double[]>
            {
                ["Stress"] = results.Select(r => r.Stress).ToArray(),
                ["TestDurationBeforeFailure"] = results.Select(r => r.TestDurationBeforeFailure).ToArray(),
                ["RelativeElongation_1"] = results.Select(r => r.RelativeElongation).ToArray(),
                ["RelativeReductionArea_1"] = results.Select(r => r.RelativeReductionArea).ToArray()
            };

            CalculateStatistics(values);
        }

        //private void SelectItem()
        //{
        //    AllStageObjUser.SelectedItem.DbSetStageManufact.DbObjMPK.BasicInfoMPK = 
        //}

        private void CalculateStatistics(Dictionary<string, double[]> properties)
        {
            Dictionary<string, StatisticsResult> statistics = new Dictionary<string, StatisticsResult>();

            foreach (KeyValuePair<string, double[]> property in properties)
            {
                List<double> values = property.Value.ToList();
                double average = values.Count > 0 ? values.Average() : 0;
                double standardDeviation = values.Count > 0 ? CalculateStandardDeviation(values, average) : 0;

                statistics[property.Key] = new StatisticsResult
                {
                    Average = Math.Round(average, 2),
                    StandardDeviation = Math.Round(standardDeviation, 2)
                };
            }

            UpdateStatisticsResults(statistics);
        }

        private static double CalculateStandardDeviation(List<double> values, double average)
        {
            double sumOfSquares = values.Sum(v => Math.Pow(v - average, 2));
            return Math.Sqrt(sumOfSquares / values.Count());
        }

        private void UpdateStatisticsResults(Dictionary<string, StatisticsResult> statistics)
        {
            //StatisticsResultsStage2 resultsView = AllStageObjUser.SelectedItem.DbSetStageTestObjView.StatisticsResults;

            //if (statistics.ContainsKey("YieldStrengthLow"))
            //    resultsView.YieldStrengthLow = statistics["YieldStrengthLow"];
            //if (statistics.ContainsKey("UltimateStrengthLow"))
            //    resultsView.UltimateStrengthLow = statistics["UltimateStrengthLow"];
            //if (statistics.ContainsKey("RelativeElongationLow"))
            //    resultsView.RelativeElongationLow = statistics["RelativeElongationLow"];
            //if (statistics.ContainsKey("RelativeReductionAreaLow"))
            //    resultsView.RelativeReductionAreaLow = statistics["RelativeReductionAreaLow"];

            //if (statistics.ContainsKey("YieldStrength"))
            //    resultsView.YieldStrength = statistics["YieldStrength"];
            //if (statistics.ContainsKey("UltimateStrength"))
            //    resultsView.UltimateStrength = statistics["UltimateStrength"];
            //if (statistics.ContainsKey("RelativeElongation"))
            //    resultsView.RelativeElongation = statistics["RelativeElongation"];
            //if (statistics.ContainsKey("RelativeReductionArea"))
            //    resultsView.RelativeReductionArea = statistics["RelativeReductionArea"];


            //if (statistics.ContainsKey("CrossSectionalArea"))
            //    resultsView.CrossSectionalArea = statistics["CrossSectionalArea"];
            //if (statistics.ContainsKey("ImpactStrength"))
            //    resultsView.ImpactStrength = statistics["ImpactStrength"];

            //if (statistics.ContainsKey("Stress"))
            //    resultsView.Stress = statistics["Stress"];
            //if (statistics.ContainsKey("TestDurationBeforeFailure"))
            //    resultsView.TestDurationBeforeFailure = statistics["TestDurationBeforeFailure"];
            //if (statistics.ContainsKey("RelativeElongation_1"))
            //    resultsView.RelativeElongation_1 = statistics["RelativeElongation_1"];
            //if (statistics.ContainsKey("RelativeReductionArea_1"))
                //resultsView.RelativeReductionArea_1 = statistics["RelativeReductionArea_1"];
        }
    }
}
