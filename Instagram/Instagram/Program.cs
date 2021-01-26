using System;
using Instagram.Models;

namespace Instagram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Users user = new Users();
            user.setUserName("Erick");
            user.setEmail("erick@email.com");


            Console.WriteLine("User:" + user.getUserName() + ": " + user.getEmail());
        }

    }

    public class Users
    {
        private string userName = "";
        private string email = "";

        public string getUserName()
        {
            return userName;
        }
        public void setUserName(string uName)
        {
            userName = uName;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email2)
        {
            email = email2;
        }
    }
    public class Roles
    {
    }
    public class Images
    {

    }
    public class Posts
    {

    }
    public class Comments
    {

    }
}                