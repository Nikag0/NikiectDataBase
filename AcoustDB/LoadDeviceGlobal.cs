using ChromeBar;
using SaveConfigObject;
using System;
using System.Xml.Serialization;
using ModelsClass;

namespace SettingsApp
{
    [Serializable]
    public partial class LoadDevice : ObjectClassSettings
    {
        [XmlElement("SDeviceGlobalFunc")]
        public ProgrammGlobalFunc SDeviceGlobalFunc { get; set; }
        public ColorThemeWindow ColorThemeWin { get; set; } = ColorThemeWindow.Dark;


        public override void PostLoad()
        {

        }

        protected override void Reset()
        {
            SDeviceGlobalFunc = new ProgrammGlobalFunc();
        }
    }
}
