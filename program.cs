using System;
using System.Collections.Generic;
namespace GhostBehindTheDoor
{
    static class Globals
    {
        // global int
        public static int counter = 0;
        public static int pos_logo_x = 150;
        public static int pos_logo_y = 0;
        public static int pos_doors_x = 0;
        public const int pos_doors_y = 10;
        public static int pos_ghost_x = 0;
        public static int pos_ghost_y = 10;
        public static bool GameOver = false;
    }
    public class GhostBehindTheDoor
    {
        public static void Main()
        {
            Console.Clear();
            title();
            logo();
            doors();
            Ghost_Game();
        }
        public static void logo()
        {
            Globals.pos_logo_x = 150;
            string[] logo = {
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@", "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@", "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@", "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@", "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&#BB@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@&&&&&&&###########BBBBBBBBBBGGPP5YYJ????&@@@@@@@@@@@@", "@@@@@@@@@@@@@@@&#BBBGGGGGGGGGGGBBBBBGGGP55YJJ????????????G@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@#BGBBBBBBBBBBBGGGP55YJJ????????????????????5@@@@@@@@@@@@", "@@@@@@@@@@@@#BGBBBBBGGPP55YJJ????????????????????????????J&@@@@@@@@@@@",
                "@@@@@@@@@@&BGGPP5YYJJ?????????????????????????????????????#@@@@@@@@@@@", "@@@@@@@@&PJJJ?????????????????????????????????????????????P@@@@@@@@@@@",
                "@@@@@@@@&5Y???????????!..!??????7:.!??????????????????????Y@@@@@@@@@@@", "@@@@@@@@&555J?????????!  ~??????!  ~???????????????????????&@@@@@@@@@@",
                "@@@@@@@@&5555Y????????!  ^~^~!??!  :~^~!?7:^7??!~!??7^:!???G@@@@@@@@@@", "@@@@@@@@&555555J??????!  .^:  :7!  .^:. .!. .?7.  !?: .7???5@@@@@@@@@@",
                "@@@@@@@@&555555J??????!  .^:  :7!  .^:. .!. .?7.  !?: .7???5@@@@@@@@@@", "@@@@@@@@&555555P5J????!  ~JJ!  ~!  ~JJ!  ^7  ^: . .^  !????J&@@@@@@@@@",
                "@@@@@@@@&555555555Y???!  :~~. .7!  :~~. .!?~   :?:   ^??????#@@@@@@@@@", "@@@@@@@@&GP555555555J?7^^^::^~7?7^^^::^~7???~^^7?7^^~???????P@@@@@@@@@",
                "@@@@@@@@@@&BP55555555Y????????????YYJJJ?YYY?JJJJ?JJJJJ??????Y@@@@@@@@@", "@@@@@@@@@@@@@&BP5555555J??????????Y5Y555555555Y5Y5YPY55?????J&@@@@@@@@",
                "@@@@@@@@@@@@@@@@#GP5555P5J???????????????????????????????JPB&@@@@@@@@@", "@@@@@@@@@@@@@@@@@@@#GP5555Y??????????????????????????J5G#@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@&#G5555J????????????????????JYG#@@@@@@@@@@@@@@@@@", "@@@@@@@@@@@@@@@@@@@@@@@@&BP55Y????????????????YPB&@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@&BP55Y????????????????YPB&@@@@@@@@@@@@@@@@@@@@", "@@@@@@@@@@@@@@@@@@@@@@@@@@@&BP5J??????????J5B&@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#G5?????J5G#@@@@@@@@@@@@@@@@@@@@@@@@@@@@", "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#5YP#&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#5YP#&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@", "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@", "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@"
            };
            List<string> TodoList = new List<string>();
            TodoList.AddRange(logo);
            foreach (string logo_line in logo)
            {
                //System.Threading.Thread.Sleep(10);
                Console.SetCursorPosition(Globals.pos_logo_x, Globals.pos_logo_y);
                Console.WriteLine(logo_line);
                Globals.pos_logo_y = Globals.pos_logo_y + 1;
            }
            Globals.pos_logo_y = 0;
        }
        public static void doors()
        {
            Console.SetCursorPosition(Globals.pos_doors_x, Globals.pos_doors_y);
            Console.WriteLine(@"
 __________   __________   __________
|  __  __  | |  __  __  | |  __  __  |
| |  ||  | | | |  ||  | | | |  ||  | |
| |  ||  | | | |  ||  | | | |  ||  | |
| |__||__| | | |__||__| | | |__||__| |
|  __  __()| |  __  __()| |  __  __()|
| |  ||  | | | |  ||  | | | |  ||  | |
| |  ||  | | | |  ||  | | | |  ||  | |
| |  ||  | | | |  ||  | | | |  ||  | |
| |  ||  | | | |  ||  | | | |  ||  | |
| |__||__| | | |__||__| | | |__||__| |
|__________| |__________| |__________|
");
        }
        public static void title()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(@"
  ________.__                    __      ________                       
 /  _____/|  |__   ____  _______/  |_   /  _____/_____    _____   ____  
/   \  ___|  |  \ /  _ \/  ___/\   __\ /   \  ___\__  \  /     \_/ __ \ 
\    \_\  \   Y  (  <_> )___ \  |  |   \    \_\  \/ __ \|  Y Y  \  ___/ 
 \______  /___|  /\____/____  > |__|    \______  (____  /__|_|  /\___  >
        \/     \/           \/                 \/     \/      \/     \/
");
        }
        public static void Ghost_Game()
        {
            Random random = new Random();
            ConsoleKeyInfo keyInfo;
            while (Globals.GameOver == false)
            {
                title();
                logo();
                doors();
                Console.SetCursorPosition(Globals.pos_doors_x, Globals.pos_doors_y + 15);
                Console.WriteLine(@"Punkte: {0}

Hinter einer T??r verbirgt sich der Geist. Welche T??r w??hlst du? 1, 2 oder 3?", Globals.counter);
                Console.SetCursorPosition(Globals.pos_doors_x, Globals.pos_doors_y + 20);
                int door = random.Next(1, 4);
                
                keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.NumPad1:
                        if (door == 1)
                        {
                            ghost(1);
                        }
                        else
                        {
                            Console.WriteLine("Der Geist befand sich nicht hinter T??r 1");
                        }
                        break;
                    case ConsoleKey.NumPad2:
                        if (door == 2)
                        {
                            ghost(2);
                        }
                        else
                        {
                            Console.WriteLine("Der Geist befand sich nicht hinter T??r 2");
                        }
                        break;
                    case ConsoleKey.NumPad3:
                        if (door == 3)
                        {
                            ghost(3);
                        }
                        else
                        {
                            Console.WriteLine("Der Geist befand sich nicht hinter T??r 3");
                        }
                        break;
                    case ConsoleKey.D1:
                        if (door == 1)
                        {
                            ghost(1);
                        }
                        else
                        {
                            Console.WriteLine("Der Geist befand sich nicht hinter T??r 1");
                        }
                        break;
                    case ConsoleKey.D2:
                        if (door == 2)
                        {
                            ghost(2);
                        }
                        else
                        {
                            Console.WriteLine("Der Geist befand sich nicht hinter T??r 2");
                        }
                        break;
                    case ConsoleKey.D3:
                        if (door == 3)
                        {
                            ghost(3);
                        }
                        else
                        {
                            Console.WriteLine("Der Geist befand sich nicht hinter T??r 3");
                        }
                        break;
                    default:
                        Console.WriteLine("{0} ist keine g??ltige Option", keyInfo.Key);
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                        Ghost_Game();
                        break;
                          
                }
                Globals.counter++;
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
        }
        public static void ghost(int door)
        {
            Console.Clear();
            title();
            logo();
            Console.SetCursorPosition(Globals.pos_ghost_x, Globals.pos_ghost_y);
            string[] ghost = {
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&BG5J?!~~^::::::::^^~!7JYPB#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&B5?!^::.....................:::^!?YP#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@&BY!^:..........................:::::::::^!JP#@@@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@GJ~:....:...........................:::::::^^^^~75#@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@#Y~:..:::..............................::::::::^^^^^^~?P&@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@#J^..::::...............................::::::::::^^^^^~~~!Y#@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@#J^.:::::::..............................:::::::::::^^^^^^~~~~!Y&@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@5^::::::::::.................:............::::.^PJ^::^^^^^^^~~~~~7P@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@&?:::::::::::::................^77~:..........:~JBY?5J~::^^^^^~~~~~~~?#@@@@@@@@@@@@@",
                "@#Y?7?YG#@@@@@@B!:::::::::::::::.................^?YYJ?7!!77JYPGY~::^755?~^^^^^^^7!~!!7G@@@@@@@@@@@@",
                "P^.....:^!YB@@#!^^:::::::::::::::...................:~!B#5JYB#!::::::::~J5G5YJJY55!~!!!!P@@@@@@@@@@@",
                "~:::..:::::^75?~^^::::::::::::::::....................:BGY77Y#Y:::::::^::?#Y7P#J7~~~!!!!7P@@@@@@@@@@",
                "~^::::::::::::^~^^::::::::::::::::..................:::5BPPPP#5::::::^^^^!#PY5B5^~~~!!!777G@#BGPGB&@",
                "J~^^::::::::^^^^^^:::::::::::::::::..............:::::::YGBBBP~::::^^^^^^^J#GGBG~~~!!!!777?7^:..:^!P",
                "B!~~^^^^^^^^^^^^^^^^:::::::::::::::::.....:.::::::::::::.^~!~:::::^^^^^^^^^75GG?~~~!!!7777?7^::::^^!",
                "@J!!~~~^^^^^^^^^^^^^:::::::::::::::::::::::::::::::::::::::::::^^^^^^^^^^^^^^~~~~~!!!!777???!~^^^^~7",
                "@B7!!!~~~^^^^^^^^^^^^^::::::::::::::::::::::::::::::::::::::::^^^^^^^^^^^^^~~~~~~!!!77777???7!~~^~!5",
                "@@P!!!!!~~~~~^^^^^^^^^^^::::::::::::::::::::^^::::::::::::^^^^^^^^^^^^^^^~~~~~~!!!!77777?????!!!~!?&",
                "@@@Y!!!!!!~~~~~~~~^^^^^^^^^::::::::::::^^^~~~~~^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~!!!7777?????????!!!!7B@",
                "@@@@Y!!!!!!!!!~~~~~~^^^^^^^^^^^^^^^^^^^^^~!!!!7Y?7!!!~~~~~~~~~~~~~~~~~!!!!!!!7777777!77?????7777!P@@",
                "@@@@@5~!!!!!!!!!!~~~~~~^^^^^^^^^^^^^^^^^~~!!77P#57777???77777777!!!77777!7777777!J5J!77????7777!P@@@",
                "@@@@@@P!!!!!!!!!!!~~~~~~~~~~~~^^^^^^^^^~~!!!!7GBG7~~~!775G???????J7?????J7??????Y&#J7????7777!!G@@@@",
                "@@@@@@@B7~!!!!!!!!!!!~~~~~~~~~~~~~~~~~~~~!!!!?BB#Y^^~~!JB#5!!!!7GBJ7777JBY7?777?#&57?????777!?#@@@@@",
                "@@@@@&##B7~!!!!!!!!!!!!!~~~~~~~~~~~~~~~~~~!!!?B###7^^~7B###Y~~?GBBG?!!JBBG?!!~!B&G7?????77775@@@@@@@",
                "@@@@Y::::^^~!!!!!!!!!!!!!!!!!!!!!!~~~~~~~~!!!7G##&G~^?B#####GPBBBBBB5PBBBBP~^!G&B???????77!J@@@@@@@@",
                "@@@@?.::...:~!!!!!!!!!!!!!!!!!!!!!!!!!~~~~!!!!P&&&&BP&&&&####BBBBBBBBBBBBBB5JG&BJ??????777!#@@@@@@@@",
                "@@@@#~^^^:::^!!!!!777777777777!!!!!!!!!!!!~!!!J&&&&&&&&&&###BBBBBBBBBBBBBBBB##BJ???????77!P@@@@@@@@@",
                "@@@@@B!~~~^^^~!!!!77777777777777777!!!!!!!!!!!7G############BBBBBBBBBBBBBBBB#B?7??????77~Y@@@@@@@@@@",
                "@@@@@@#?!!!~~~~!!!7777777777777777777!!!!!!!!!!J###BBBBBB###BBBBBBBBBBBBBBB#G777?????77~J@@@@@@@@@@@",
                "@@@@@@@@P7!!!!!!!!!7777777777777777777!!!!!!!!!7P##BGGGGGGBBBBGGGBBBBBBBBB#5!!7?????7!~Y@@@@@@@@@@@@",
                "@@@@@@@@@#Y!!!!!!!!!!7777777777777777777!!!!!!!!7GBGGGGGGGGGGBBGGGGBBBBBBBJ!!7????77!!P@@@@@@@@@@@@@",
                "@@@@@@@@@@@#Y!!!77!!!!!777777777777777777!!!!!!!!7PGGPPPPPPPPGGGGPPPGGBBP7~!7???77!~?#@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@#57~!!!!!!!!77777777777777777!!!!!!!!7PGPP55555PPPGGP55PPGJ~!77??77!~7P@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@&GJ!~~!!!!!!!!!77777777777!!!!!!!!!!JPPP55555555PPGP555P5?7??77!~7P&@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@&P?!~~~~~!!!!!!!!!!!!!!!!!!!!!777?YP55YYYYYYY55PP5YY55PJ7!!!?G@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@&GJ7~^^~~~~~!!!!!!!!!!!!!!!777??55YYYYYYYYY55P5YYY55P?75#@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@#PJ7~^^^~~~~~~~!!!!!!!!!!!77Y5YYJJJJJYYY5PP5YYY555&@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&BPJ?!~~^^^^^~~~~~~~~~~~Y5YJJJJJJJYYY5P5YYYY55G@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&#BG5YJ?7!!!~~~~~~~55YJJ?JJJJJYY5P5YYYYY55#@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&#####BP5YJJ?JJJJJYY5P5YYYYY55G@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@BPYYJJJJJJJJYY5P5YYYYY55P@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&P5YJJJJJJJJJYY5P5YYYY555P@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#P5YJJJJJJJJYYY5P5YYY5555P@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@BP5YYJJJJJJJYYY555YYY555YG@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#P5YYYJJJJJJYYY5555Y555Y5&@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@G555YYYJJJJYYYY555YYYYY#@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B555YYYYYYYYYYYYYYYJ5#@@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&GP555YYYYYYYYYYY5B@@@@@@@@@@@@@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&#GP55YYYYY5PG#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@"
            };
            List<string> Ghost_Ascii = new List<string>();
            Ghost_Ascii.AddRange(ghost);
            foreach (string ghost_line in Ghost_Ascii)
            {
                Console.WriteLine(ghost_line);
                Globals.pos_ghost_y = Globals.pos_ghost_y + 1;
                System.Threading.Thread.Sleep(10);
            }
            var text = "";
            if (Globals.counter == 1)
            {
                text = "Punkt";
            }
            else
            {
                text = "Punkte";
            }
            Console.SetCursorPosition(Globals.pos_ghost_x, Globals.pos_ghost_y + 2);
            Console.WriteLine("Game Over! Der Geist befand sich hinter T??r {0}.\nDu hast {1} {2}", door, Globals.counter, text);
            Console.SetCursorPosition(Globals.pos_ghost_x, Globals.pos_ghost_y + 5);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dr??cke eine Taste um nochmal zu spielen.");
            Console.ForegroundColor = ConsoleColor.White;
            Globals.pos_ghost_y = 10;
            Console.ReadKey();
            reset();

        }
        public static void reset()
        {
            Globals.counter = 0;
            Main();
        }
    }
}
