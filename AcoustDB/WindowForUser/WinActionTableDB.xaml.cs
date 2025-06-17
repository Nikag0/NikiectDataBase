using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ViewModels;

namespace AcoustDB.WindowForUser
{
    /// <summary>
    /// Логика взаимодействия для WinActionTableDB.xaml
    /// </summary>
    public partial class WinActionTableDB : Window
    {
        public WinActionTableDB(ProgrammGlobalFuncViewModel globalFuncViewModel)
        {
            InitializeComponent();

            DataContext = globalFuncViewModel;
        }
    }
}
