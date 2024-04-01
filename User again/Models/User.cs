using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_again.Models
{
    internal class User
    {
        private string _name = "YYY";
        private string _surname = "XXX";
        private string _userName;
        private string _password = "12345678";

        
        public string Name 
        { 
            get
            {
                return _name;
            } 
            set
            {
                if(CheckLetter(value.Trim()) && value.Length>2 && value.Length<25 )
                {
                    _name = Capitalize(value);
                }
                else
                {
                    Console.WriteLine("ad yanlisdir");
                }
            }
        }
         
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (CheckLetter(value.Trim()) /*&& value.Length > 5 && value.Length < 25*/)
                {
                    _surname =Capitalize(value);
                }
                else
                {
                    Console.WriteLine("soyad yanlisdir");
                }
            }
        }
        public string UserName
        {
            get
            {
                return _userName;
            }
        }

        public string Password
        {
            set
            {
                if (value.Length >= 5 && CheckLower(value) && CheckUpper(value) && CheckDigit(value))
                {
                   _password = value;
                    /*Console.WriteLine(_password);*/
                }
                else
                {
                    Console.WriteLine("Password minim 1 herf 1 kcik herf bir eded olmalidir");
                }

            }
        }

        public User(string name, string surname, string password)
        {
            Name = name;
            Surname = surname;
            _userName = string.Concat(Name.Substring(0, 3), '.', Surname.Substring(0, 3));
            Password = password;
        }

        public void ChangePassword(string oldPass,string newPass)
        {
            if (oldPass == _password) 
            {
                Password = newPass;
            }
            else
            {
                Console.WriteLine("password yanlisdir");
            }
        }

       private string Capitalize(string name) 
        {
            name = name.Trim();
            return String.Concat(name.Substring(0, 1).ToUpper(), name.Substring(1).ToLower());
        }
        private bool CheckLetter(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckLower(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsLower(word[i]))
                {
                    return true;
                }
            }
            return false;
        }



        public bool CheckUpper(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsUpper(word[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckDigit(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsDigit(word[i]))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
