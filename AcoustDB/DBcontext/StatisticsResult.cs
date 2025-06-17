using INotifyChangedCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBcontext
{
    public class StatisticsResult : INotifyChanged
    {
        private double average = 0;
        private double standardDeviation = 0;

        public double Average
        {
            get => average;
            set
            {
                average = value;
                NotifyPropertyChanged();
            }
        }
        public double StandardDeviation
        {
            get => standardDeviation;
            set
            {
                standardDeviation = value;
                NotifyPropertyChanged();
            }
        }
    }
}
