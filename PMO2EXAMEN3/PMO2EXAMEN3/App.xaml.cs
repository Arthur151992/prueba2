using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMO2EXAMEN3
{
    public partial class App : Application
    {
        public static string UBICACIONDB=string.Empty;

        public App()
        {
            InitializeComponent();

            MainPage =  new NavigationPage(new MainPage());
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public App(string dblocal)
        {

            InitializeComponent();
            UBICACIONDB=dblocal;
            MainPage = new NavigationPage(new MainPage());

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
