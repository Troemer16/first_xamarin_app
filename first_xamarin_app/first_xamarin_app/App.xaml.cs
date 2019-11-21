using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace first_xamarin_app
{
    public partial class App : Application
    {
        public static string dbPath;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public App(string filePath)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            dbPath = filePath;

            using (Stream source = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DB/test.db"))
            {
                using (var destination = File.Create(dbPath))
                {
                    source.CopyTo(destination);
                }
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
