using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E6
{
    public class Person
    {
        private static Person _instance;
        private String name;
        private String email;

        public Person() { }

        public static Person Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Person();
                }
                return _instance;
            }
        }

        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
    }
}