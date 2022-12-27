using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reg_window
{
// класс для хранения данных о пользователе
    public class User
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
// конструктор по умолчанию 
        public User() { }
// конструктор с параметрами
        public User(string? name, string? password, string? email)
        {
            Name = name;
            Password = password;
            Email = email;
        }
    }
}
