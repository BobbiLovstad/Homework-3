using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Written By Bobbi Lovstad
// 2/16/25
namespace Homework3_CIS122
{
   public class Arrows
    {
        public static void Main(string[] args)
        {
            Arrow arrow = GetArrow();
            Console.WriteLine($"The cost of the arrow {arrow.GetCost()} in gold");

            Arrow GetArrow()
            {
                ArrowHead arrowHead = GetArrowHeadType();
                Fletching fletching = GetFletchingType();
                float length = GetLength();
                return new Arrow(arrowHead, fletching, length);
            }

            ArrowHead GetArrowHeadType()
            {
                Console.Write("Steel, wood obsidian");
                string input = Console.ReadLine();
                return input switch
                {
                    "steel" => ArrowHead.Steel,
                    "Wood" => ArrowHead.Wood,
                    "Obsidian" => ArrowHead.Obsidian,


                };
            }
            Fletching GetFletchingType();
            {
                Console.Write("Plastic, Turkey, Goose")
                string input = Console.ReadLine();
                return input switch
                {
                    "Plastic" => Fletching.Plastic,
                    "Turkey" => Flectching.Turkey,
                    "Goose" => Fletching.Goose,



                };
            }

            float GetLength()
            {
                float length = 0;
                while (length < 60 || length > 100)
                {
                    Console.Write("arrowlength between 60 nd 100");
                    length = Convert.ToSingle(Console.ReadLine());

                }
                return length;
            }
           class Arrow
        { 
            public ArrowHead_arrowhead;
            public Fletching_fletching;
            public float_length;

            public Arrow(ArrowHead arrowhead, Fletching fletching, float length)
            {
                _arrowhead = arrowhead;
                _fletching = fletching;
                _length = length;
            }
            public float GetCost()
            {
                float arrowheadcost = _arrowhead switch
                {
                    ArrowHead.Steel => 10,
                    ArrowHead.Wood => 3,
                    ArrowHead.Obsidian => 5

                };

                float flectchingcost = _fletching switch
                {
                    Fletching.Plastic => 10,
                    Fletching.Turkey => 5,
                    Fletching.Goose => 3
                };

                float shaftcost = 0.05f * _length;
                return arrowheadcost + fletchingcost + shaftcost;
            }



        }
        //Enumurations 
        enum ArrowHead { Steel, Wood, Obsidian }
        enum Fletching { Plastic, Turkey, Goose }
    }
}


