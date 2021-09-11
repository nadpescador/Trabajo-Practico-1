using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Practico_1
{
    abstract class User  
    {
        public int id { get; set; }
        public int dni { get; set; }
        public String name { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public Car car { get; set; }



        User(int id, int dni, String name, String lastName, String email, String password, Car car) {
            this.id = id;
            this.dni = dni;
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.car = car;
        }

        public override string ToString()
        {
            return String.Format("{0}")
        }
    }

}
