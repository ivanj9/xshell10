using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xshell10.Services;
using xshell10.Views;

namespace xshell10
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
