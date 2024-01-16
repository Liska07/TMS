using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    public class Square
    {
        private int _sideLength;
        public int SideLength 
        {
            get 
            { 
                return _sideLength; 
            }
            set 
            {
                _sideLength = value;
                areaOfSquare = value * value;
            } 
        }
        private int areaOfSquare;

        public string Color {  get; set; }

        public Square(int sideLength, string color) 
        {
            SideLength = sideLength;
            Color = color;
        }

        public void ShowInfo(string nameSquare)
        {
            Console.WriteLine($"\nЦвет {nameSquare} квадрата: {Color}");
            Console.WriteLine($"Длинна стороны {nameSquare} квадрата = {SideLength}");
            Console.WriteLine($"Площадь {nameSquare} квадрата = {areaOfSquare}");
            
        }
    }
}

