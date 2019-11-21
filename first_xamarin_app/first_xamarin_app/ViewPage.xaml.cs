using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using first_xamarin_app.Classes;

namespace first_xamarin_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewPage : ContentPage
    {
        public ViewPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.dbPath))
            {
                List<Employee> employees = conn.Table<Employee>().ToList();
            }
        }
    }
}