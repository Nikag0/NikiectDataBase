using INotifyChangedCustom;
using System.Collections.Generic;

namespace DBcontext
{
    public class FileControlData : INotifyChanged
    {
        private List<DescriptFile> fileInfo = new List<DescriptFile>();
        private int countFile = 0;


        public List<DescriptFile> FileInfo
        {
            get => fileInfo;
            set
            {
                fileInfo = value;
                NotifyPropertyChanged();
            }
        }

        public int CountFile
        {
            get => countFile;
            set
            {
                countFile = value;
                NotifyPropertyChanged();
            }
        }


        public void AddData(DescriptFile data)
        {
            FileInfo.Add(data);
            CountFile = fileInfo.Count;
            NotifyPropertyChanged(nameof(FileInfo));
        }

    }
}
