using INotifyChangedCustom;
using System;

namespace DBcontext
{
    public class GeneralMethodData : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private string technologCardNum = "";
        private string nameRegulatoryDoc = "";
        private string testMethod = "";
        private string organizationTesting = "";


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

        public string TechnologCardNum
        {
            get => technologCardNum;
            set
            {
                technologCardNum = value;
                NotifyPropertyChanged();
            }
        }
        public string NameRegulatoryDoc
        {
            get => nameRegulatoryDoc;
            set
            {
                nameRegulatoryDoc = value;
                NotifyPropertyChanged();
            }
        }
        public string TestMethod
        {
            get => testMethod;
            set
            {
                testMethod = value;
                NotifyPropertyChanged();
            }
        }
        public string OrganizationTesting
        {
            get => organizationTesting;
            set
            {
                organizationTesting = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }

    }
}
