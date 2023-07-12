using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects
{
    internal class car
    {

        private string _name; // private field typically used for storing datea.
        private int _hp;
        private string _color;

        public void setName(string name)
        {
            if (name == "") 
            {
                _name = "DefaultName";
            }else
            {
                _name = name;
            }
            
        }


        // Constructor
        public car()
        {
            _name = "car";
            _hp = 0;
            _color = "red";
        }
        public car(string name, int hp = 0, string color = "black")
        {
            _name = name;
            Console.WriteLine(name + " Car was created ");
            _hp = hp;
            _color = color;
        }

        public void Drive()
        {

            Console.WriteLine(_name + "car is driving");
        }

        public void Stop()
        {
            Console.WriteLine(_name + "Car stopped");
        }

        public void Details()
        {
            Console.WriteLine("The " + _color + " car " + _name + "has " + _hp + "hp");
        }
    }
}
