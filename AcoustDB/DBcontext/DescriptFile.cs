using INotifyChangedCustom;

namespace DBcontext
{
    public class DescriptFile : INotifyChanged
    {
        private string pathFile = "";
        private string nameFile = "";

        public string PathFile
        {
            get => pathFile;
            set
            {
                pathFile = value;
                NotifyPropertyChanged();
            }
        }

        public string NameFile
        {
            get => nameFile;
            set
            {
                nameFile = value;
                NotifyPropertyChanged();
            }
        }
    }
}
