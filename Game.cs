using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public static class Game
    {
        public static void SelectKnight()
        {
            bool goodSelection= false;
            
            while(goodSelection == false)
            try
            {
                Console.WriteLine("\nSelect the knight with their correspondent number:\n\n    1. William Wallace\n    2. Rodrigo Díaz de Vivar\n    3. Saint George\n    4. John Dumbar\n    5. Sir Galahad\n");

                int knightSelected = Int32.Parse(Console.ReadLine());

                if (knightSelected < 1 || knightSelected > 5)
                {
                    throw new ArgumentException("The number you put doesn't correspond to any knight.");

                    goodSelection = false;
                }
                else
                {
                    Console.WriteLine($"\nGood choice, you have selected {knightSelected} as your kniht.\n");
                        
                    goodSelection = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                goodSelection = false;
            }
        }

        public static void Menu() 
        {
            bool selectMenuNum = false;
            
            while( selectMenuNum == false )
            {
                try
                {
                    Console.WriteLine("\nMAIN MENU:\n\nSelect an option by its corresponding number:\n\n    1. STATISTICS\n    2. INVENTORY\n    3. FIGHT\n");

                    int numberSelected = Int32.Parse(Console.ReadLine());

                    if ( numberSelected < 1 || numberSelected > 3)
                    {
                        throw new ArgumentException("The number you put doesn't correspond to any option on the menu.");

                        selectMenuNum = false;
                    }
                    else
                    {
                        selectMenuNum = true;
                    }
                    if (numberSelected == 1)
                    {
                        bool statisticChose = false;

                        while (statisticChose == false)
                        {
                            try
                            {
                                Console.WriteLine("\nSTATISTICS\n\nSelect an option you want to see by its corresponding number:\n\n    1. Number of games played\n    2. Number of fights won\n    3. Number of fights lost\n    4. Return to MAIN MENU\n");

                                int statisticSelected = Int32.Parse(Console.ReadLine());

                                if (statisticSelected < 1 || statisticSelected > 4)
                                {
                                    throw new ArgumentException("The number you put doesn't correspond to any option on the STATISTICS menu.");

                                    statisticChose = false;
                                }
                                else if (statisticSelected == 1)
                                {
                                    Console.WriteLine($"\nYour knight XXXXX has played XXXX batles.\n\nPulse any keyboard to return to STATISTICS menu.\n");

                                    string anyKey = Console.ReadLine();

                                    statisticChose = false;
                                }
                                else if (statisticSelected == 2)
                                {
                                    Console.WriteLine($"\nYour knight XXXXX has won XXXX batles.\n\nPulse any keyboard to return to STATISTICS menu.\n");

                                    string anyKey = Console.ReadLine();

                                    statisticChose = false;
                                }
                                else if (statisticSelected == 3)
                                {
                                    Console.WriteLine($"\nYour knight XXXXX has lost XXXX batles.\n\nPulse any keyboard to return to STATISTICS menu.\n");
                                    
                                    string anyKey = Console.ReadLine();

                                    statisticChose = false;
                                }
                                else if (statisticSelected == 4)
                                {
                                    statisticChose = true;

                                    selectMenuNum = false;
                                }
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);

                                statisticChose = false;
                            }
                        }
                    }
                }catch(Exception ex) 
                { 
                    Console.WriteLine(ex.Message);

                    selectMenuNum = false;
                }
            }
        }



        public static void Start()
        {
            Console.WriteLine("|||||||||||||||=============== \"MEDIEVAL KNIGHTS Vs EPIC MONSTERS\" GAME ===============|||||||||||||||\n");

            Console.WriteLine("Loading...\n\nPulse any keyboard to start the game...\n");
            string starting = Console.ReadLine();

            SelectKnight();

            Menu();
        }     

    }
}
