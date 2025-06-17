using ChromeBar;
using ErrorsHandlerWork;
using INotifyChangedCustom;
using ModelsClass;
using SaveConfigObject;
using SettingsApp;
using System.Linq;
using UserMessageBox;

namespace ModelsForView
{
    public class MainModel : INotifyChanged
    {
        public MainModel()
        {
            loadDevice.Load("ConfigMain.xml");
            DevGlobFunc = loadDevice.AppData.SDeviceGlobalFunc;
            DevGlobFunc.RegisterHandlerError(new ViewErrorHandler(ShowError));
            DevGlobFunc.LoadDataThis();

            MenuBar = new MenuBarModel();
        }

        private MenuBarModel menuBar;
        private ProgrammGlobalFunc devGlobFunc;

        private Settings<LoadDevice> loadDevice = new Settings<LoadDevice>();

        public MenuBarModel MenuBar
        {
            get => menuBar;
            private set
            {
                menuBar = value;
                NotifyPropertyChanged();
            }
        }

        public ProgrammGlobalFunc DevGlobFunc
        {
            get => devGlobFunc;
            private set
            {
                devGlobFunc = value;
                NotifyPropertyChanged();
            }
        }

        public ColorThemeWindow ColorThemeWin
        {
            get => loadDevice.AppData.ColorThemeWin;
            set
            {
                loadDevice.AppData.ColorThemeWin = value;
                NotifyPropertyChanged();
            }
        }

        private void ShowError(ErrorItemGlobal error)
        {
            System.Action actionShow = () => MyMessageBox.ShowDialog(error.ReadError.TextError, error.ReadError.HeaderError, MessageBoxButtons.Ok);
            System.Windows.Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background, actionShow);
        }

        public void SaveAppConfig()
        {
            loadDevice.Save();
            DevGlobFunc.ContextAcoustDB.SaveCatalog();
        }
    }
}
