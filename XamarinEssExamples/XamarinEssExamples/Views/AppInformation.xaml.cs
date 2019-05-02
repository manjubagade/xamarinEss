using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace XamarinEssExamples.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppInformation : ContentPage
	{
		public AppInformation ()
		{
			InitializeComponent ();
            labelappinfo.Text = $"{AppInfo.Name}";
            labelvertioninfo.Text = $"{AppInfo.VersionString}" + $"{AppInfo.BuildString}";      
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            AppInfo.ShowSettingsUI();
        }
    }
}