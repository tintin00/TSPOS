using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Skins.Info;
using DevExpress.XtraBars.Docking2010.Customization;
using System;
using System.Linq;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Internal;
using System.Reflection;
using System.IO;

namespace TS.DevExpress.Test
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += OnCurrentDomainAssemblyResolve;
            DataDirectoryHelper.LocalPrefix = "WinHybridApp";
            bool exit;
            using (IDisposable singleInstanceApplicationGuard = DataDirectoryHelper.SingleInstanceApplicationGuard("DevExpressWinHybridApp", out exit))
            {
                if (exit) return;
                WindowsFormsSettings.SetDPIAware();
                ////MessageBox.Show("pause");
                SkinManager.EnableFormSkins();
                UserSkins.BonusSkins.Register();
                ((DevExpress.LookAndFeel.Design.UserLookAndFeelDefault)DevExpress.LookAndFeel.Design.UserLookAndFeelDefault.Default).LoadSettings(() =>
                {
                    var skinCreator = new SkinBlobXmlCreator("HybridApp",
                        "DevExpress.HybridApp.Win.SkinData.", typeof(Program).Assembly, null);
                    SkinManager.Default.RegisterSkin(skinCreator);
                });
                AsyncAdornerBootStrapper.RegisterLookAndFeel(
                    "MetroBlack", "DevExpress.RealtorWorld.Win.SkinData.", typeof(Program).Assembly);
                LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("HybridApp");
                Application.CurrentCulture = CultureInfo.GetCultureInfo("en-us");

                DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = Utils.DefaultBoolean.True;
                DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = XtraEditors.ScrollUIMode.Touch;
                float touchScaleFactor, fontSize;
                DevExpress.DevAV.Common.Utils.DeviceDetector.SuggestHybridDemoParameters(out touchScaleFactor, out fontSize);
                WindowsFormsSettings.DefaultFont = new Font("Segoe UI", fontSize);
                WindowsFormsSettings.DefaultMenuFont = new Font("Segoe UI", fontSize);
                UserLookAndFeel.Default.TouchScaleFactor = touchScaleFactor;

                //if (!IsTablet || Screen.PrimaryScreen.WorkingArea.Height < 900) {
                //    WindowsFormsSettings.DefaultFont = new Font("Segoe UI", 10);
                //    WindowsFormsSettings.DefaultMenuFont = new Font("Segoe UI", 10);
                //    UserLookAndFeel.Default.TouchScaleFactor = 1.5f;
                //}

                //if(IsTablet && Screen.PrimaryScreen.WorkingArea.Width > 1900) {
                //    WindowsFormsSettings.DefaultFont = new Font("Segoe UI", 12);
                //    WindowsFormsSettings.DefaultMenuFont = new Font("Segoe UI", 12);
                //    UserLookAndFeel.Default.TouchScaleFactor = 2.5f;
                //}
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
        public static Icon AppIcon
        {
            get { return DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.HybridApp.Win.Resources.AppIcon.ico", typeof(MainForm).Assembly); }
        }
        public static MainForm MainForm { get; set; }
        private static bool? isTablet = null;
        public static bool IsTablet
        {
            get
            {
                if (isTablet == null)
                {
                    //do not call before form is created - it will ruin application on highdpi - due HasTouch
                    isTablet = DevExpress.DevAV.Common.Utils.DeviceDetector.IsTablet;
                }
                return isTablet.Value;
            }
        }
        static Assembly OnCurrentDomainAssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (DevExpress.Utils.AssemblyHelper.GetPartialName(args.Name) == "EntityFramework")
            {
                string path = Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "EntityFramework.dll");
                return Assembly.LoadFrom(path);
            }
            return null;
        }
    }
}
