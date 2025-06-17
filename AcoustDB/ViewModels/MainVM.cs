using ChromeBar;
using ICommandForWpf;
using INotifyChangedCustom;
using ModelsForView;
using System.Windows;
using System.Windows.Input;

namespace ViewModels
{
    public class MainViewModel : INotifyChanged
    {
        public MainViewModel()
        {

        }

        public MainViewModel(Window winArea)
        {
            curWindow = winArea;
            curWindow.Closed += WinArea_Closed;
            WindowChromeView = new WindowChromeViewModel(curWindow);
            MenuBarViewMod = new MenuBarViewModel(mainModelHead.MenuBar);
            ViewModelDevice = new ProgrammGlobalFuncViewModel(mainModelHead.DevGlobFunc);

            ViewModelDevice.UpdateView();
            InitCommand();
            SetColorTheme(mainModelHead.ColorThemeWin);
        }

        private MainModel mainModelHead = new MainModel();
        private readonly Window curWindow;

        public ICommand DarkThemeButton { get; private set; }
        public ICommand WhiteThemeButton { get; private set; }

        public MenuBarViewModel MenuBarViewMod { get; private set; }
        public ProgrammGlobalFuncViewModel ViewModelDevice { get; private set; }
        public WindowChromeViewModel WindowChromeView { get; private set; }

        private void InitCommand()
        {
            DarkThemeButton = new RelayCommand(delegate
            {
                SetColorTheme(ColorThemeWindow.Dark);
            });
            WhiteThemeButton = new RelayCommand(delegate
            {
                SetColorTheme(ColorThemeWindow.White);
            });
        }

        private void SetColorTheme(ColorThemeWindow value)
        {
            mainModelHead.ColorThemeWin = value;
            WindowChromeView.WindowChromeModel.CurColorTheme = mainModelHead.ColorThemeWin;
        }


        private void WinArea_Closed(object sender, System.EventArgs e)
        {
            mainModelHead.SaveAppConfig();
        }
    }
}
