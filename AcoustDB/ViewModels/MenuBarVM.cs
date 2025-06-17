using ICommandForWpf;
using ModelsForView;
using Printers;
using System.Windows.Input;

namespace ViewModels
{
    public class MenuBarViewModel
    {
        public MenuBarViewModel(MenuBarModel barModel)
        {
            menuBar = barModel;
            InitCommand();
        }

        private MenuBarModel menuBar;

        public ICommand? OpenWinProgrammInfo { get; private set; }
        public ICommand? OpenWinSettingsCatalogs { get; private set; }



        private void InitCommand()
        {
            OpenWinProgrammInfo = new RelayCommand(p => menuBar.OpenWinProgrammInfo());
            OpenWinSettingsCatalogs = new RelayCommand(p => menuBar.OpenWinSettingsCatalogs((ProgrammGlobalFuncViewModel)p));


        }
    }
}
