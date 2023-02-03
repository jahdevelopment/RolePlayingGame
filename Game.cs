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
                        throw new ArgumentException("The number you put doesn't correspond to any option in the MAIN MENU.");

                        selectMenuNum = false;
                    }
                    else if (numberSelected == 1) // Statistics menu
                    {
                        selectMenuNum = true;

                        bool statisticChosen = false;

                        while (statisticChosen == false)
                        {
                            try
                            {
                                Console.WriteLine("\nSTATISTICS\n\nSelect an option you want to see by its corresponding number:\n\n    1. Number of games played\n    2. Number of fights won\n    3. Number of fights lost\n    4. Return to MAIN MENU\n");

                                int statisticSelected = Int32.Parse(Console.ReadLine());

                                if (statisticSelected < 1 || statisticSelected > 4)
                                {
                                    throw new ArgumentException("The number you put doesn't correspond to any option in the STATISTICS menu.");

                                    statisticChosen = false;
                                }
                                else if (statisticSelected == 1)
                                {
                                    Console.WriteLine($"\nYour knight XXXXX has played XXXX batles.\n\nPulse any keyboard to return to STATISTICS menu.\n");

                                    string anyKey = Console.ReadLine();

                                    statisticChosen = false;
                                }
                                else if (statisticSelected == 2)
                                {
                                    Console.WriteLine($"\nYour knight XXXXX has won XXXX batles.\n\nPulse any keyboard to return to STATISTICS menu.\n");

                                    string anyKey = Console.ReadLine();

                                    statisticChosen = false;
                                }
                                else if (statisticSelected == 3)
                                {
                                    Console.WriteLine($"\nYour knight XXXXX has lost XXXX batles.\n\nPulse any keyboard to return to STATISTICS menu.\n");
                                    
                                    string anyKey = Console.ReadLine();

                                    statisticChosen = false;
                                }
                                else if (statisticSelected == 4)
                                {
                                    statisticChosen = true;

                                    selectMenuNum = false;
                                }
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);

                                statisticChosen = false;
                            }
                        }
                    }
                    else if (numberSelected == 2) // Inventory menu
                    {
                        selectMenuNum = true;
                        
                        bool inventoryChosen = false;

                        while (inventoryChosen == false)
                        {
                            try
                            {
                                Console.WriteLine("\nINVENTORY\n\nSelect an option by its corresponding number:\n\n    1. Change the equipped weapon\n    2. Change the equipped armour\n    3. Back to MAIN MENU\n");

                                int inventorySelected = Int32.Parse(Console.ReadLine());

                                if (inventorySelected < 1 || inventorySelected > 3)
                                {
                                    throw new ArgumentException("The number you put doesn't correspond to any option in the INVENTORY menu.");

                                    inventoryChosen = false;
                                }
                                else if (inventorySelected == 1)
                                {
                                    inventoryChosen = true;

                                    bool weaponChosen = false;

                                    while (weaponChosen == false)
                                    {
                                        try
                                        {
                                            Console.WriteLine($"Select a weapon of the list above by its corresponding number:\n\n       NAME         ||    POWER\n    1. Katana       ||     85\n    2. Falchion     ||     95\n    3. Longsword    ||     105\n    4. ArmingSword  ||     100\n    5. Estoc        ||     110\n");

                                            int weaponSelected = Int32.Parse(Console.ReadLine());

                                            if (weaponSelected < 1 || weaponSelected > 5)
                                            {
                                                throw new ArgumentException("The number you put doesn't correspond to any option in the Weapon list.");

                                                weaponChosen = false;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"\nNow you have selected the weapon \"{weaponSelected}\" for your knight XXXX.\n\nPulse any keyboard to return to INVENTORY menu.\n");

                                                string anyKey = Console.ReadLine();

                                                weaponChosen = true;

                                                inventoryChosen = false;
                                            }
                                        } catch(Exception ex) 
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                    }
                                }
                                else if (inventorySelected == 2)
                                {
                                    inventoryChosen = true;

                                    bool armourChosen = false;

                                    while (armourChosen == false)
                                    {
                                        try
                                        {
                                            Console.WriteLine($"Select an armour of the list above by its corresponding number:\n\n       NAME               ||    POWER\n    1. The Iron Fortress  ||     55\n    2. Death's Oath       ||     65\n    3. The Brass Dome     ||     70\n    4. Gambeson           ||     85\n    5. Scale Armour       ||     90\n");

                                            int armourSelected = Int32.Parse(Console.ReadLine());

                                            if (armourSelected < 1 || armourSelected > 5)
                                            {
                                                throw new ArgumentException("The number you put doesn't correspond to any option in the Armour list.\"");

                                                armourChosen = false;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"\nNow you have selected the armour \"{armourSelected}\" for your knight XXXX.\n\nPulse any keyboard to return to INVENTORY menu.\n");

                                                string anyKey = Console.ReadLine();

                                                armourChosen = true;
                                                
                                                inventoryChosen = false;
                                            }
                                        } catch(Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                    }
                                }
                                else if (inventorySelected == 3)
                                {
                                    inventoryChosen= true;

                                    selectMenuNum = false;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                    else if (numberSelected == 3) // Fight menu
                    {

                    }
                }
                catch(Exception ex) 
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
