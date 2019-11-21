using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace first_xamarin_app.Classes
{
    class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        [MaxLength(3)]
        public int Age { get; set; }

        public string Position { get; set; }
    }
}
