using System;
namespace test.Models
{
    public class Userclass
    {
        private string _username;
        private int _age;
        private string _password;

       
        public string username { get { return _username; } set { _username = value; } }

        public int age
        { get
         {
                return _age;
         }
          set 
         {
                if (value<=0)
                {
                    Console.WriteLine("age cannot be negative!");
                    return;
                }
                _age = value;
         }
        }

        public string pass {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length!=0 && value.Length >= 8  && Cases(value) == true)
                {
                    Console.WriteLine("password be set");
                    _password = value;
                    return;
                    
                }
                Console.WriteLine("Password can not be less than 8 symbols or empty");
                return;
              
                          }
        }
        public bool Cases (string pass)
        {
            bool res1 = false;
            bool res2 = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsUpper(pass[i])==true)
                {
                    res2 = true;
                }
                if (char.IsNumber(pass[i])==true)
                {
                    res1 = true;
                }  
            }
             bool res = res1 && res2;
            return res;

        }
        
        

    }
}
