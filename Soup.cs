using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Written by Bobbi Lovstad
//2/16/25
namespace Homework3_CIS122
{
    public class Soup
    {
        //Enumurations
        enum SoupType { Soup, Stew, Gumbo }
        enum MainIngredient { Mushroom, Carrot, Chicken, Potatoe }

        enum Seasoning { Sweet, Salty, Spicy }
        public static void Main(string[] args)
        {
            // Tuple Variable 
            (SoupType type, MainIngredient ingredient, Seasoning seasoning) soup = GetSoup();
            Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.type}");

            //Letting user pick from selected ingredients 
            (SoupType, MainIngredient, Seasoning) GetSoup()
            {
                SoupType type = GetSoupType();
                MainIngredient ingredient = GetMainIngredient();
                Seasoning seasoning = GetSeasoning();
                return (type, ingredient, seasoning);
            }

            SoupType GetSoupType()
            {
                Console.Write("soup, stew, or gumbo");
                string input = Console.ReadLine();
                return input switch
                {
                    "soup" => SoupType.Soup,
                    "stew" => SoupType.Stew,
                    "gumbo" => SoupType.Gumbo,

                };
            }
            SoupType GetSoupType()
            {
                Console.Write("Mushroom, chicken, carrot, potatoe")
                string input = Console.ReadLine();
                return input switch
                {
                    "Mushroom" => MainIngredient.Mushroom,
                    "Carrot" => MainIngredient.Carrot,
                    "Potatoe" => MainIngredient.Potatoe,
                    "Chicken" => MainIngredient.Chicken,
                };
            }

            Seasoning GetSeasoning()
            {
                Console.Write("Spicy,Salty,Sweet)
                string input = Console.ReadLine();
                return input switch
                {

                    "Sweet" => Seasoning.Sweet,
                    "Salty" => Seasoning.Salty,
                    "Spicy" => Seasoning.Spicy,
                };
            }
        }
    }
}
