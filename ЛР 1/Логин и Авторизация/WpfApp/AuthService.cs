using System;

namespace WpfApp
{
    public class AuthService
    {
        public bool Authenticate(string username, string password)
        {
            return username == "user" && password == "pass";
        }
    }
}