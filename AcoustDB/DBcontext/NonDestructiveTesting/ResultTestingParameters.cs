using INotifyChangedCustom;
using System;
using System.Collections.Generic;

namespace DBcontext
{
    public class ResultTestingParameters : INotifyChanged
    {
        private Guid id = Guid.NewGuid();
        private string nameThis = "";

        private double valueUser = 0;
        private string stringUser = "";

        private FileControlData fileUser_0 = new FileControlData();
        private FileControlData fileUser_1 = new FileControlData();
        private FileControlData fileUser_2 = new FileControlData();
        private FileControlData fileUser_3 = new FileControlData();

        private string paramString_0 = "";
        private string paramString_1 = "";
        private string paramString_2 = "";
        private string paramString_3 = "";
        private string paramString_4 = "";
        private string paramString_5 = "";
        private string paramString_6 = "";
        private string paramString_7 = "";
        private string paramString_8 = "";
        private string paramString_9 = "";

        private double paramDouble_0 = 0;
        private double paramDouble_1 = 0;
        private double paramDouble_2 = 0;
        private double paramDouble_3 = 0;
        private double paramDouble_4 = 0;
        private double paramDouble_5 = 0;
        private double paramDouble_6 = 0;
        private double paramDouble_7 = 0;
        private double paramDouble_8 = 0;
        private double paramDouble_9 = 0;
        private double paramDouble_10 = 0;
        private double paramDouble_11 = 0;
        private double paramDouble_12 = 0;
        private double paramDouble_13 = 0;
        private double paramDouble_14 = 0;
        private double paramDouble_15 = 0;
        private double paramDouble_16 = 0;


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

        public double ValueUser
        {
            get => valueUser;
            set
            {
                valueUser = value;
                NotifyPropertyChanged();
            }
        }
        public string StringUser
        {
            get => stringUser;
            set
            {
                stringUser = value;
                NotifyPropertyChanged();
            }
        }

        public FileControlData FileUser_0
        {
            get => fileUser_0;
            set
            {
                fileUser_0 = value;
                NotifyPropertyChanged();
            }
        }
        public FileControlData FileUser_1
        {
            get => fileUser_1;
            set
            {
                fileUser_1 = value;
                NotifyPropertyChanged();
            }
        }
        public FileControlData FileUser_2
        {
            get => fileUser_2; set
            {
                fileUser_2 = value;
                NotifyPropertyChanged();
            }
        }
        public FileControlData FileUser_3
        {
            get => fileUser_3; set
            {
                fileUser_3 = value;
                NotifyPropertyChanged();
            }
        }
        public string ParamString_0
        {
            get => paramString_0; set
            {
                paramString_0 = value;
                NotifyPropertyChanged();
            }
        }
        public string ParamString_1
        {
            get => paramString_1; set
            {
                paramString_1 = value;
                NotifyPropertyChanged();
            }
        }
        public string ParamString_2
        {
            get => paramString_2; set
            {
                paramString_2 = value;
                NotifyPropertyChanged();
            }
        }
        public string ParamString_3
        {
            get => paramString_3; set
            {
                paramString_3 = value;
                NotifyPropertyChanged();
            }
        }
        public string ParamString_4
        {
            get => paramString_4; set
            {
                paramString_4 = value;
                NotifyPropertyChanged();
            }
        }
        public string ParamString_5
        {
            get => paramString_5; set
            {
                paramString_5 = value;
                NotifyPropertyChanged();
            }
        }
        public string ParamString_6
        {
            get => paramString_6; set
            {
                paramString_6 = value;
                NotifyPropertyChanged();
            }
        }
        public string ParamString_7
        {
            get => paramString_7; set
            {
                paramString_7 = value;
                NotifyPropertyChanged();
            }
        }
        public string ParamString_8
        {
            get => paramString_8; set
            {
                paramString_8 = value;
                NotifyPropertyChanged();
            }
        }
        public string ParamString_9
        {
            get => paramString_9; set
            {
                paramString_9 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_0
        {
            get => paramDouble_0; set
            {
                paramDouble_0 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_1
        {
            get => paramDouble_1; set
            {
                paramDouble_1 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_2
        {
            get => paramDouble_2; set
            {
                paramDouble_2 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_3
        {
            get => paramDouble_3; set
            {
                paramDouble_3 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_4
        {
            get => paramDouble_4; set
            {
                paramDouble_4 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_5
        {
            get => paramDouble_5; set
            {
                paramDouble_5 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_6
        {
            get => paramDouble_6; set
            {
                paramDouble_6 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_7
        {
            get => paramDouble_7; set
            {
                paramDouble_7 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_8
        {
            get => paramDouble_8; set
            {
                paramDouble_8 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_9
        {
            get => paramDouble_9; set
            {
                paramDouble_9 = value;
                NotifyPropertyChanged();
            }
        }

        public double ParamDouble_10
        {
            get => paramDouble_10;
            set
            {
                paramDouble_10 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_11
        {
            get => paramDouble_11;
            set
            {
                paramDouble_11 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_12
        {
            get => paramDouble_12; set
            {
                paramDouble_12 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_13
        {
            get => paramDouble_13; set
            {
                paramDouble_13 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_14
        {
            get => paramDouble_14; set
            {
                paramDouble_14 = value;
                NotifyPropertyChanged();
            }
        }
        public double ParamDouble_15
        {
            get => paramDouble_15; set
            {
                paramDouble_15 = value;
                NotifyPropertyChanged();
            }
        }

        public double ParamDouble_16
        {
            get => paramDouble_16; set
            {
                paramDouble_16 = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return NameThis;
        }
    }
}
