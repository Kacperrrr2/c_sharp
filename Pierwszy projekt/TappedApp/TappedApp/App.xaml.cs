using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TappedApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            TabbedPage tabbedPage= new TabbedPage();
            tabbedPage.Children.Add(new FirstPage() { Title = "Pierwsza" });
            tabbedPage.Children.Add(new SecondPage() { Title = "Druga" });
            tabbedPage.Children.Add(new ThirdPage() { Title = "Trzecia" });
            tabbedPage.Children.Add(new ThirdPage() { Title = "4" });
            tabbedPage.Children.Add(new ThirdPage() { Title = "555" });

            MainPage = tabbedPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
