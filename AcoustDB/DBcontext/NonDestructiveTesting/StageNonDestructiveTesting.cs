using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBcontext
{
    public class StageNonDestructiveTesting : INotifyChanged
    {
        public StageNonDestructiveTesting()
        {
            ultrasonicTestingMethod.TableTestingTools.Add(new GeneralTestingParameters() { TypeTool = "Дефектоскоп", NameUserIn = "", SerialNumber = "" });
            ultrasonicTestingMethod.TableTestingTools.Add(new GeneralTestingParameters() { TypeTool = "Пьезоэлетрический преобрабователь", NameUserIn = "", SerialNumber = "" });
            ultrasonicTestingMethod.TableTestingTools.Add(new GeneralTestingParameters() { TypeTool = "Стандартный образец", NameUserIn = "", SerialNumber = "" });
            ultrasonicTestingMethod.TableTestingTools.Add(new GeneralTestingParameters() { TypeTool = "Настроечный образец", NameUserIn = "", SerialNumber = "" });
            ultrasonicTestingMethod.TableTestingTools.Add(new GeneralTestingParameters() { TypeTool = "Контактная среда", NameUserIn = "", SerialNumber = "" });

            ultrasonicTestingMethod.TableEquipmentParameters.Add(new GeneralTestingParameters() { TypeTool = "Задержка, мкс", NameUserIn = "", SerialNumber = "" });
            ultrasonicTestingMethod.TableEquipmentParameters.Add(new GeneralTestingParameters() { TypeTool = "Длительность разверки, мкс", NameUserIn = "", SerialNumber = "" });
            ultrasonicTestingMethod.TableEquipmentParameters.Add(new GeneralTestingParameters() { TypeTool = "Базовое усиление, дБ", NameUserIn = "", SerialNumber = "" });
            ultrasonicTestingMethod.TableEquipmentParameters.Add(new GeneralTestingParameters() { TypeTool = "Поисковый уровень Ап, дБ", NameUserIn = "", SerialNumber = "" });
            ultrasonicTestingMethod.TableEquipmentParameters.Add(new GeneralTestingParameters() { TypeTool = "Контрольный уровень Ак, дБ", NameUserIn = "", SerialNumber = "" });
            ultrasonicTestingMethod.TableEquipmentParameters.Add(new GeneralTestingParameters() { TypeTool = "Браковочный уровень Абр, дБ", NameUserIn = "", SerialNumber = "" });

            ultrasonicTestingMethod.TableTestingParameters.Add(new GeneralTestingParameters() { TypeTool = "Термпература, ℃", NameUserIn = "", SerialNumber = "" });
            ultrasonicTestingMethod.TableTestingParameters.Add(new GeneralTestingParameters() { TypeTool = "Скорость сканирования, мм/с", NameUserIn = "", SerialNumber = "" });
            ultrasonicTestingMethod.TableTestingParameters.Add(new GeneralTestingParameters() { TypeTool = "Шаг сканирования, мм", NameUserIn = "", SerialNumber = "" });
            ultrasonicTestingMethod.TableTestingParameters.Add(new GeneralTestingParameters() { TypeTool = "Объем контроля, %", NameUserIn = "", SerialNumber = "" });

           //******************//

            tomographicTestingMethod.TableTestingTools.Add(new GeneralTestingParameters() { TypeTool = "Томограф", NameUserIn = "", SerialNumber = "" });
            tomographicTestingMethod.TableTestingTools.Add(new GeneralTestingParameters() { TypeTool = "Стандартный образец", NameUserIn = "", SerialNumber = "" });

            tomographicTestingMethod.TableEquipmentParameters.Add(new GeneralTestingParameters() { TypeTool = "Время экспозиции, мкс", NameUserIn = "", SerialNumber = "" });

            tomographicTestingMethod.TableTestingParameters.Add(new GeneralTestingParameters() { TypeTool = "Скорость вращения град/с", NameUserIn = "", SerialNumber = "" });
            tomographicTestingMethod.TableTestingParameters.Add(new GeneralTestingParameters() { TypeTool = "Шаг сканирования, мм", NameUserIn = "", SerialNumber = "" });

            //******************//

            acousticEmissionTestingMethod.TableTestingTools.Add(new GeneralTestingParameters() { TypeTool = "АЭ аппаратура", NameUserIn = "", SerialNumber = "" });
            acousticEmissionTestingMethod.TableTestingTools.Add(new GeneralTestingParameters() { TypeTool = "Преобразователи акустической эмиссии", NameUserIn = "", SerialNumber = "" });
            acousticEmissionTestingMethod.TableTestingTools.Add(new GeneralTestingParameters() { TypeTool = "Предварительные усилители ", NameUserIn = "", SerialNumber = "" });
            acousticEmissionTestingMethod.TableTestingTools.Add(new GeneralTestingParameters() { TypeTool = "Имитатор сигналов", NameUserIn = "", SerialNumber = "" });
            acousticEmissionTestingMethod.TableTestingTools.Add(new GeneralTestingParameters() { TypeTool = "Контактная среда", NameUserIn = "", SerialNumber = "" });

            acousticEmissionTestingMethod.TableEquipmentParameters.Add(new GeneralTestingParameters() { TypeTool = "Задержка, мкс", NameUserIn = "", SerialNumber = "" });
            acousticEmissionTestingMethod.TableEquipmentParameters.Add(new GeneralTestingParameters() { TypeTool = "Длительность разверки, мкс", NameUserIn = "", SerialNumber = "" });
            acousticEmissionTestingMethod.TableEquipmentParameters.Add(new GeneralTestingParameters() { TypeTool = "Базовое усиление, дБ", NameUserIn = "", SerialNumber = "" });
            acousticEmissionTestingMethod.TableEquipmentParameters.Add(new GeneralTestingParameters() { TypeTool = "Поисковый уровень Ап, дБ", NameUserIn = "", SerialNumber = "" });
            acousticEmissionTestingMethod.TableEquipmentParameters.Add(new GeneralTestingParameters() { TypeTool = "Контрольный уровень Ак, дБ", NameUserIn = "", SerialNumber = "" });
            acousticEmissionTestingMethod.TableEquipmentParameters.Add(new GeneralTestingParameters() { TypeTool = "Браковочный уровень Абр, дБ", NameUserIn = "", SerialNumber = "" });

            acousticEmissionTestingMethod.TableTestingParameters.Add(new GeneralTestingParameters() { TypeTool = "Термпература, ℃", NameUserIn = "", SerialNumber = "" });
            acousticEmissionTestingMethod.TableTestingParameters.Add(new GeneralTestingParameters() { TypeTool = "Скорость сканирования, мм/с", NameUserIn = "", SerialNumber = "" });
            acousticEmissionTestingMethod.TableTestingParameters.Add(new GeneralTestingParameters() { TypeTool = "Шаг сканирования, мм", NameUserIn = "", SerialNumber = "" });
            acousticEmissionTestingMethod.TableTestingParameters.Add(new GeneralTestingParameters() { TypeTool = "Объем контроля, %", NameUserIn = "", SerialNumber = "" });
        }


        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private GeneralTestingMethod ultrasonicTestingMethod = new GeneralTestingMethod();
        private GeneralTestingMethod tomographicTestingMethod = new GeneralTestingMethod();
        private GeneralTestingMethod acousticEmissionTestingMethod = new GeneralTestingMethod();


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

        public GeneralTestingMethod UltrasonicTestingMethod
        {
            get => ultrasonicTestingMethod;
            set
            {
                ultrasonicTestingMethod = value;
                NotifyPropertyChanged();
            }
        }
        public GeneralTestingMethod TomographicTestingMethod
        {
            get => tomographicTestingMethod;
            set
            {
                tomographicTestingMethod = value;
                NotifyPropertyChanged();
            }
        }
        public GeneralTestingMethod AcousticEmissionTestingMethod
        {
            get => acousticEmissionTestingMethod;
            set
            {
                acousticEmissionTestingMethod = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
