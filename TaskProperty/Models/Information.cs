using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProperty.Models
{
    public class Information
    {
        public string UserName;
        private int Salariy;
        List<Information> usernamelist = new List<Information>();

        //public void AddUsername(string username)
        //{
        //    if (username == null)
        //    {
        //        Console.WriteLine("Please Enter username :");
        //        username = Console.ReadLine();
        //    }
        //    else
        //    {
        //        usernamelist.Add(new Information { UserName = username });
        //    }
        //}

        public string username
        {
            get { return UserName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    UserName = value;
                }
                else
                {
                    Console.WriteLine("plese enter username : ");

                }

            }
        }

        public int Salary
        {
            get { return Salariy; }
            set
            {
                if (value >= 350 && value <= 900)
                {
                    Salariy = value;
                }
                else
                {
                    Console.WriteLine("Salary out of range");
                }
            }
        }
    }
}
