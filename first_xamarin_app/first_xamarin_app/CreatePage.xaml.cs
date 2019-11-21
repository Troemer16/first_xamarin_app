using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using first_xamarin_app.Classes;
using SQLite;

namespace first_xamarin_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreatePage : ContentPage
    {
        public CreatePage()
        {
            InitializeComponent();
        }

        void AddEmployeeButton(object sender, System.EventArgs e)
        {
            Employee newEmployee = new Employee()
            {
                Name = NameEntry.Text,
                Age = Int32.Parse(AgeEntry.Text),
                Position = PositionEntry.Text
            };

            using(SQLiteConnection conn = new SQLiteConnection(App.dbPath))
            {

            }
        }
    }
}