using System;

namespace lesson_8
{
    public class User
    {
        #region Fields
        public string Type = "Player";
        protected int Code = 101;
        private double _version = 0.1;

        #endregion

        #region Properties

        public string Name { get; set; }
        protected string Login { get; set; }
        private string Password { get; set; }

        #endregion

        #region Methods

        public void PrintUserInfo()
        {
            Console.WriteLine($"Type: {this.Type}\nCode: {this.Code}\nVersion: {this._version}" +
                              $"\nName: {this.Name}\nLogin: {this.Login}\nPassword: {this.Password}");
        }

        public void Say(string message)
        {
            Console.WriteLine($"{message}");
        }

        protected double GetVersion()
        {
            return _version;
        }

        private void ChangePassword(string newPassword)
        {
            Password = newPassword;
        }

        #endregion

        #region Constructors
        public User()
        {
            Name = "admin";
            Login = "admin";
            Password = "admin";
        }

        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }

        #endregion
    }
}