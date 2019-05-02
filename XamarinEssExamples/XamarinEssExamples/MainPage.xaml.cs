using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinEssExamples.Models;
using XamarinEssExamples.Views;

namespace XamarinEssExamples
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.MenuList = new List<MasterPageItem>();
            this.MenuList.Add(new MasterPageItem() { Title = "APP INFORMATION", Icon = "keep.png", TargetType = typeof(AppInformation) });
            this.MenuList.Add(new MasterPageItem() { Title = "OPen Browser", Icon = "rem.png", TargetType = typeof(OpenBrowser) });
            this.MenuList.Add(new MasterPageItem() { Title = "Create new label", Icon = "plus.png", TargetType = typeof(HomePage) });
            this.MenuList.Add(new MasterPageItem() { Title = "Archive", Icon = "archive.png", TargetType = typeof(HomePage) });
            this.MenuList.Add(new MasterPageItem() { Title = "Trash", Icon = "delete.png", TargetType = typeof(HomePage) });
            this.MenuList.Add(new MasterPageItem() { Title = "Setting", Icon = "setting.png", TargetType = typeof(HomePage) });
            this.navigationDrawerList.ItemsSource = this.MenuList;
            this.Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }
        public IList<MasterPageItem> MenuList { get; set; }

        /// <summary>
        /// Called when [item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="SelectedItemChangedEventArgs"/> instance containing the event data.</param>
        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            this.Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            this.IsPresented = false;
        }
    }
}
