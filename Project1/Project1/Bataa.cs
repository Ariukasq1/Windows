using System;
namespace Bataa
{
    namespace LAB1 { 

    public class TASK1

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
            public void half(int h) {
                _id -= h;
                Console.WriteLine(_id);
            }


    }
        

 }
}
