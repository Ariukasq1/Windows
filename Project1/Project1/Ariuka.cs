using System;
namespace Ariuka
{
    namespace Lab1
    {

    
    public class Task1
    {
            private int _id = 100;
            public int ID {

                get
                {
                    return _id;
                }
                set
                {
                    _id = value;
                }
                
            }
            public void Hewleh ()
            {
                
                Console.WriteLine(_id);
            }
            public void Oruulah()
            {
                Console.WriteLine("Garnaas utga oruulna uu?:");
                string _id = Console.ReadLine();
                Console.WriteLine("Garnaas oruulsan utga bol:"+ _id);
            }

        }
 }
}
