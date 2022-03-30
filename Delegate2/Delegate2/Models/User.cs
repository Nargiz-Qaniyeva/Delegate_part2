using Delegate2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate2.Models
{
    internal class User : IEntity
    {
        public string  Username { get; set; }
        private static int _id ;
        public int Id { get; }
        public string  Email { get; set; }
        public Role Role { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"UserName:{Username}- E-mail:{Email}");
        }
        public User()
        {
            _id++;
            Id = _id;
            this.Username = Username;
            this.Email = Email;
            this.Role = Role;
        }
    }
}
