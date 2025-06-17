using DBcontext;
using ErrorsHandlerWork;
using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ModelsClass
{
    public class ProgrammGlobalFunc : INotifyChanged
    {
        public ProgrammGlobalFunc()
        {
            SetErrors();
        }

        private ErrorsWorkerClass errorsWorker;

        private ActionAcoustContextDB contextAcoustDB = new ActionAcoustContextDB();



        [XmlIgnore]
        public ActionAcoustContextDB ContextAcoustDB
        {
            get => contextAcoustDB;
            set
            {
                contextAcoustDB = value;
                NotifyPropertyChanged();
            }
        }


        public void LoadDataThis()
        {
            ContextAcoustDB.LoadCatalog();
        }

        #region Работа с ошибками.
        private void SetErrors()
        {
            string nameFileErrors = "HeadDocP";

            errorsWorker = new ErrorsWorkerClass(new List<ErrorItem> {
                new ErrorItem { UserKeyError = 00100100, TextError = $"Ошибка записи данных в БД.\nДанный номер договора уже существует.\n" },
                new ErrorItem { UserKeyError = 00100200, TextError = $"Не удалось установить соединение с блоком управления двигателями\nПроверьте кабели и подключите в настройках" },
                new ErrorItem { UserKeyError = 00100300, TextError = $"Для формирования акта приема-передачи авто, необходимо чтобы в базе существовал ДКП по данному номеру договора." },
                new ErrorItem { UserKeyError = 00100400, TextError = $"Ошибка принтера.\nПроверьте настройки и принтер по умолчанию." },
                new ErrorItem { UserKeyError = 00100500, HeaderError = "Сообщение", TextError = $"Документ успешно сформирован." },
                }, nameFileErrors);
        }

        /// <summary>
        /// Регистрирует внешний метод для выдачи ошибок.
        /// </summary>
        public void RegisterHandlerError(ViewErrorHandler errorHandler)
        {
            if (errorHandler != null)
            {
                errorsWorker?.RegisterHandlerError(errorHandler);
                //DevDocument?.RegisterHandlerError(errorHandler);
            }
        }

        #endregion
    }
}
