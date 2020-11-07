using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XFEAppInfoSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            AppName.Text = AppInfo.Name;
            PackageName.Text = AppInfo.PackageName;
            Version.Text = AppInfo.Version.ToString();
            Build.Text = AppInfo.BuildString;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            AppInfo.ShowSettingsUI();
        }
    }
}
