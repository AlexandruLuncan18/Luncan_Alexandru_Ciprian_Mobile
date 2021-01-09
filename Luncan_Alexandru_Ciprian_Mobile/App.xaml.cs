using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Luncan_Alexandru_Ciprian_Mobile.Data;
using System.IO;

namespace Luncan_Alexandru_Ciprian_Mobile
{       
    public partial class App : Application
    {
        static AgendaDatabase database;
        public static AgendaDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new AgendaDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new AgendaPage());
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
