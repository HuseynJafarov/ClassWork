using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_Namespace_DLL_AccessModifiers_
{
    class Car
    {
      
        public string brand;
        private int _horsePower;
        private readonly int speed;
        //public string color { get;private set; }
        public Car()
        {
            speed = 500;
        }
        
        public int HorsePower

        {
            get
            {
                if (_horsePower < 150)
                {
                    //return _horsePower;
                    Console.WriteLine("Can't drive");
                    return -1;
                }
                return _horsePower;
                //Console.WriteLine("Can't drive");
                //return -1;
            }
            
            set
            {
                if(value<100)
                {
                    Console.WriteLine("Please set correct powew");
                    return;
                }
                _horsePower = value;


            }










         }
    }
}
