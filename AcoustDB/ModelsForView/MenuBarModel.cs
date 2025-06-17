using AcoustDB.WindowForUser;
using Printers;
using ViewModels;

namespace ModelsForView
{
    public class MenuBarModel
    {
        public void OpenWinProgrammInfo()
        {
            ProgrammInfo settings = new ProgrammInfo();
            settings.ShowDialog();
        }

        public void OpenWinSettingsCatalogs(ProgrammGlobalFuncViewModel value)
        {
            WinActionTableDB settings = new WinActionTableDB(value);
            settings.Show();
        }

    }
}
