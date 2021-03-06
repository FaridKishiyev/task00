using System;
using System.Collections.Generic;
using System.Text;

namespace task2022.Moduls
{
    class User
    {
        private int _age;
        public string UserName { get; set; }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Yas menfi ola bilmez!");
                    return;
                }
                _age = value;
            }
        }

        public string Password
        {
            get
            {
                return Password;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }
                if (value.Length < 8)
                {
                    Console.WriteLine("8 simvoldan az ola bilmez");
                    return;
                }

                if (IsexistsDigit(value) == false)
                {
                    return;
                }
                if (IsexistsUpperCase(value) == false)
                {
                    return;
                }
            }
        }
        private bool IsexistsUpperCase(string value)
        {
            foreach (var item in value)
            {
                if (Char.IsUpper(item))
                {
                    Console.WriteLine("True");
                    return true;
                }
            }

            return false;
        }


        private bool IsexistsDigit(string value)
        {

            foreach (var item in value)
            {
                if (Char.IsDigit(item))
                {
                    Console.WriteLine("True");
                    return true;
                }
            }

            return false;
        }

        public User(string UserName, int age, string Password)
        {
            this.UserName = UserName;
            this.Age = age;
            this.Password = Password;
        }
    }

}
    

