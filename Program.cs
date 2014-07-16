using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program {
        static void Main(string[] args){
        }


        class Bouquet {
            private int price;
       

        }

        public enum Color { Red, Yellow, Green }

        public class Flower {
            private int price;
            private string name;
            private Color color;

            protected Flower(int price, string name, Color color)   {
                if (price < 0)
                {
                    Console.WriteLine("Что-то дешевый цветок... Больше 0 запилите.");
                }
                this.price = price;
                if (name == null)
                {
                    Console.WriteLine("Имя цветку дайте-то...");
                }
                this.name = name;
                if (color == null) 
                {
                    Console.WriteLine("Цвет цветку не помешал бы...");
                }
                this.color = color;

            }

            public int getPrice()
            {
                return price;
            }
            public string getName()
            {
                return name;
            }
            public Color getColor()
            {
                return color;
            }

        }

        public class Rouse : Flower
        {
            private static string name = "Роза";
            public Rouse(int price, Color color) {
                super(price, name, color);
            }

        }
        
        public class Violet : Flower{
            private  static String name = "Фиалка";
            public Violet(double price, Color color) {
                super(price, name, color);
            }
        }

        public class Tulip : Flower{
            private  static String name = "Тюльпан";
            public Tulip(double price, Color color) {
                super(price, name, color);
            }
        }

    }
}
