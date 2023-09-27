using System;

class Program
{
    static void Main()
    {

        string asciiArt3 = @"
                 _                                  
              (`  ).                   _           
             (     ).              .:(`  )`.       
)           _(       '`.          :(   .    )      
        .=(`(      .   )     .--  `.  (    ) )      
       ((    (..__.:'-'   .+(   )   ` _`  ) )                 
`.     `(       ) )       (   .  )     (   )  ._   
  )      ` __.:'   )     (   (   ))     `-'.-(`  ) 
)  )  ( )       --'       `- __.'         :(      )) 
.-'  (_.'          .')                    `(    )  ))
                  (_  )                     ` __.:'          
                                        
--..,___.--,--'`,---..-.--+--.,,-,,..._.--..-._.-a:f--.";

        string asciiArt2 = @"                                 ____                                         
                              .-""    `-.      ,                               
                            .'          '.   /j\                              
                           /              \,/:/#\                /\           
                          ;              ,//' '/#\              //#\          
                          |             /' :   '/#\            /  /#\         
                          :         ,  /' /'    '/#\__..--""""""""/    /#\__      
                           \       /'\'-._:__    '/#\        ;      /#, """"""---
                            `-.   / ;#\']"" ; """"""--./#J       ':____...!       
                               `-/   /#\  J  [;[;[;Y]         |      ;        
""""""""""""---....             __.--""/    '/#\ ;   "" ""  |     !    |   #! |        
             """"--.. _.--""""     /      ,/#\'-..____.;_,   |    |   '  |        
                   ""-.        :_....___,/#} ""####"" | '_.-"",   | #['  |        
                      '-._      |[;[;[;[;|         |.;'  /;\  |      |        
                      ,   `-.   |        :     _   .;'    /;\ |   #"" |        
                      !      `._:      _  ;   ##' .;'      /;\|  _,  |        
                     .#\""""""---..._    ';, |      .;{___     /;\  ]#' |__....--
          .--.      ;'/#\         \    ]! |       ""| , """"""--./_J    /         
         /  '%;    /  '/#\         \   !' :        |!# #! #! #|    :`.__      
        i__..'%] _:_   ;##J         \      :""#...._!   '  ""  ""|__  |    `--.._
         | .--"""""" !|""""""""  |""""""----...J     | '##"""" `-._       |  """"""---.._    
     ____: |      #|      |         #|     |          ""]      ;   ___...-""T,  
    /   :  :      !|      |   _______!_    |           |__..--;""""""     ,;MM;  
   :____| :    .-.#|      |  /\      /#\   |          /'               ''MM;  
    |"""""": |   /   \|   .----+  ;      /#\  :___..--"""";                  ,'MM; 
   _Y--:  |  ;     ;.-'      ;  \______/#: /         ;                  ''MM; 
  /    |  | ;_______;     ____!  |""##""""""MM!         ;                    ,'MM;
 !_____|  |  |""#""#""|____.'""""##""  |       :         ;                     ''MM  
  | """"""""--!._|     |##""""         !       !         :____.....-------"""""""""""" |'
  |          :     |______                        ___!_ ""#""""#""""#""""""#""""""#""""""|  
__|          ;     |MM""MM""""""""""---..._______...--""""MM""MM]                   |   
  ""\-.      :      |#                                  :                   |  
    /#'.    |      /##,                                !                   |  
   .',/'\   |       #:#,                                ;       .==.       |  
  /""\'#""\',.|       ##;#,                               !     ,'||||',     |  
        /;/`:       ######,          ____             _ :     M||||||M     |  
       ###          /;""\.__""-._   """"""                   |===..M!!!!!!M_____|  
                           `--..`--.._____             _!_                    
                                          `--...____,=""_.'`-.____        ";


        string asciiArt = @"
                       ,-.^._                 _
                     .'      `-.            ,' ;
          /`-.  ,----'         `-.   _  ,-.,'  `
       _.'   `--'                 `-' '-'      ;
      :                         o             ;    __,-.
      ,'    o            Mazar-i-Sharif       ;_,-',.__'--.
     :    Herat                              ,--```    `--'
     :                                      ;
     :                                      :
     ;                                      :
    (                                       ;
     `-.                           *      ,'
       ;                         Kabul   :
     .'                             .-._,'
   .'                               `.
_.'                                .__;
`._                  o            ;
   `.             Kandahar       :    ,---------------------.
     `.               ,..__,---._;    |    AFGHANISTAN      |
       `-.__         :                | Capital: Kabul      |
            `.--.____;                | Pop: 12700000       |
                                      | Area: 250000 sq.mi. |
                                      |      (647500 sq.km.)|
                                      `---------------------'";



        string asciiArt1 =
           "  .     '     ,\n" +
           "    _________\n" +
           " _ /_|_____|_\\ _\n" +
           "   '. \\   / .'\n" +
           "     '.\\ /.'\n" +
           "       '.'";

        string asciiArt9 = @",.      .   .        *   .    .      .  _    ..          .
     \,~-.         *           .    .       ))       *    .
          \ *          .   .   |    *  . .  ~    .      .  .  ,
 ,           `-.  .            :               *           ,-
  -             `-.        *._/_\_.       .       .   ,-'
  -                 `-_.,     |n|     .      .       ;
    -                    \ ._/_,_\_.  .          . ,'         ,
     -                    `-.|.n.|      .   ,-.__,'         -
      -                   ._/_,_,_\_.    ,-'              -
      -                     |..n..|-`'-'                -
       -                 ._/_,_,_,_\_.                 -
         -               ,-|...n...|                  -
           -         ,-'._/_,_,_,_,_\_.              -
             -  ,-=-'     |....n....|              -
              -;       ._/_,_,_,_,_,_\_.         -
             ,-          |.....n.....|          -
           ,;         ._/_,_,_,_,_,_,_\_.         -
  `,  '.  `.  "".  `,  '.| n   ,-.   n |  "",  `.  `,  '.  `,  ',
,.:;..;;..;;.,:;,.;:,o__|__o !.|.! o__|__o;,.:;.,;;,,:;,.:;,;;:
 ][  ][  ][  ][  ][  |_i_i_H_|_|_|_H_i_i_|  ][  ][  ][  ][  ][
                     |     //=====\\     |
                     |____//=======\\____|
 gpyy                    //=========\\";


        string asciiArt10 = @"
    (\
     \ \
 __    \/ ___,.-------..__        __
//\\ _,-'\\               `'--._ //\\
\\ ;'      \\                   `: //
 `(          \\                   )'
   :.          \\,----,         ,;
    `.`--.___   (    /  ___.--','
      `.     ``-----'-''     ,'
         -.               ,-
            `-._______.-'";




        string asciiArt11 = @"                 ___====-_  _-====___
           _--^^^#####//      \\#####^^^--_
        _-^##########// (    ) \\##########^-_
       -############//  |\^^/|  \\############-
     _/############//   (@::@)   \\############\_
    /#############((     \\//     ))#############\
   -###############\\    (oo)    //###############-
  -#################\\  / VV \  //#################-
 -###################\\/      \//###################-
_#/|##########/\######(   /\   )######/\##########|\#_
|/ |#/\#/\#/\/  \#/\##\  |  |  /##/\#/  \/\#/\#/\#| \|
`  |/  V  V  `   V  \#\| |  | |/#/  V   '  V  V  \|  '
   `   `  `      `   / | |  | | \   '      '  '   '
                    (  | |  | |  )
                   __\ | |  | | /__
                  (vvv(VVV)(VVV)vvv)";






        // ASCII logo
        string logo = @"   
       ▄████▄  ██░ ██ ▒█████  ██▓▄████▄ ▓█████ ███▄ ▄███▓▄▄▄      ██ ▄█▓█████ ██▀███   ██████
      ▒██▀ ▀█ ▓██░ ██▒██▒  ██▓██▒██▀ ▀█ ▓█   ▀▓██▀█▀ ██▒████▄    ██▄█▒▓█   ▀▓██ ▒ ██▒██    ▒
     █    ▄▒██▀▀██▒██░  ██▒██▒▓█    ▄▒███  ▓██    ▓██▒██  ▀█▄ ▓███▄░▒███  ▓██ ░▄█ ░ ▓██▄
      ▒▓▓▄ ▄██░▓█ ░██▒██   ██░██▒▓▓▄ ▄██▒▓█  ▄▒██    ▒██░██▄▄▄▄██▓██ █▄▒▓█  ▄▒██▀▀█▄   ▒   ██▒
      ▒ ▓███▀ ░▓█▒░██░ ████▓▒░██▒ ▓███▀ ░▒████▒██▒   ░██▒▓█   ▓██▒██▒ █░▒████░██▓ ▒██▒██████▒▒
      ░ ░▒ ▒  ░▒ ░░▒░░ ▒░▒░▒░░▓ ░ ░▒ ▒  ░░ ▒░ ░ ▒░   ░  ░▒▒   ▓▒█▒ ▒▒ ▓░░ ▒░ ░ ▒▓ ░▒▓▒ ▒▓▒ ▒ ░
        ░  ▒   ▒ ░▒░ ░ ░ ▒ ▒░ ▒ ░ ░  ▒   ░ ░  ░  ░      ░ ▒   ▒▒ ░ ░▒ ▒░░ ░  ░ ░▒ ░ ▒░ ░▒  ░ ░
      ░        ░  ░░ ░ ░ ░ ▒  ▒ ░          ░  ░      ░    ░   ▒  ░ ░░ ░   ░    ░░   ░░  ░  ░";




        int screenWidth = Console.WindowWidth;
        int screenHeight = Console.WindowHeight;
        int logoPadding = Math.Max((screenHeight - logo.Split('\n').Length) / 2, 0);


        Console.ForegroundColor = ConsoleColor.DarkRed;

        var i = 0;
        foreach (string line in logo.Split('\n'))
        {
            Console.SetCursorPosition(Math.Max((screenWidth - line.Length) / 2, 0), i);
            Console.WriteLine(line);
            i++;
        }
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkRed;

        logoPadding = 5;

        // Menuopties
        Console.SetCursorPosition(Math.Max((screenWidth - 7) / 2, 0), logoPadding + i);
        Console.Write("1. ");
        Console.ResetColor();
        Console.Write("Play");

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(Math.Max((screenWidth - 7) / 2, 0), logoPadding + i + 1);
        Console.Write("2. ");
        Console.ResetColor();
        Console.Write("Info");

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(0, screenHeight - 1);
        Console.Write("Copyright\u00A9: ");
        Console.ResetColor();
        Console.Write("Jim Pilon");

        Console.SetCursorPosition(Math.Max((screenWidth - 15) / 2, 0), logoPadding + i + 2);
        Console.Write("Enter your choice: ");
        string? choice1 = Console.ReadLine();

        Console.ResetColor();

        if (choice1 != null)
        {
            switch (choice1)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("let's look at the map, press enter to continue...");
                    break;

                case "2":
                    Console.WriteLine("");
                    Console.WriteLine("Welcome to the Adventure Game!");
                    Console.WriteLine("In this game, you will embark on a journey in a desert landscape.");
                    Console.WriteLine("Your goal is to solve the final puzzle to complete the game.");
                    Console.WriteLine("Along the way, you'll face choices and challenges.");
                    Console.WriteLine("Let's get started! Press Enter to begin...");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Instructions:");
                    Console.WriteLine("1. Use the keyboard to make choices.");
                    Console.WriteLine("2. Follow the objectives displayed to progress.");
                    Console.WriteLine("3. Pay attention to the story and clues.");
                    Console.WriteLine("4. Be careful with your choices; some may lead to game over.");
                    Console.WriteLine("5. Have fun and enjoy the adventure!");

                    Console.WriteLine("Press Enter to start your journey...");
                    Console.ReadLine();

                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid choice.");
        }

        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(asciiArt);

        bool continueGame = true;

        while (continueGame)
        {


            Console.WriteLine("your story takes place in Kabul, a dessert landscape, your goal is to solve the final puzzle, press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(asciiArt3);
            Console.WriteLine();
            Console.WriteLine("It's already starting to get dark, and you start looking for a hiding place");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("While looking for a place you suddenly see a castle in the distance !!! ");
            /*Console.WriteLine("You find yourself standing in front of a mysterious cave.");*/
            Console.WriteLine("do you choose to go to the castle or to make dinner? (castle/dinner)");

            string choice = ValidateInput("castle", "dinner");


            Console.Clear();
            Console.WriteLine(asciiArt2);

            switch (choice)
            {

                case "castle":

                    Console.WriteLine("Objective: Find the treasure chest.");
                    Console.WriteLine("");
                    Console.WriteLine("you are standing in front of the mysterious castle.");
                    Console.WriteLine("Do you want to go left or right? (left/right)");

                    choice = ValidateInput("left", "right");

                    Console.Clear();

                    switch (choice)
                    {
                        case "left":
                            Console.WriteLine("Objective: Solve the puzzle.");
                            Console.WriteLine("");
                            Console.WriteLine("You follow the left tunnel and find a treasure chest!");
                            Console.WriteLine("Congratulations! you have found a key and can now solve the puzzle!");

                            Console.WriteLine("Do you want to open the treasure chest? (yes/no)");
                            string openChestChoice = Console.ReadLine().ToLower();

                            if (openChestChoice == "yes")
                            {
                                Console.WriteLine("Here is your puzzle/question: What is the capital of France?");
                                string answer = Console.ReadLine().ToLower();

                                if (answer == "paris")
                                {
                                    Console.WriteLine("Correct! You have completed the puzzle!");
                                    Console.WriteLine("You have completed the game. Congratulations!");
                                }
                                else
                                {
                                    Console.WriteLine("Wrong answer. Game over!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You chose not to open the treasure chest. Game over!");
                            }

                            break;

                        case "right":
                            Console.WriteLine(asciiArt11);
                            Console.WriteLine("");
                            Console.WriteLine("You follow the right tunnel and encounter a dragon.");
                            Console.WriteLine("You were not prepared, and the dragon defeats you. Game over!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Game over!");
                            break;
                    }
                    continueGame = false;
                    break;

                case "dinner":
                    Console.Clear();
                    Console.WriteLine(asciiArt10);
                    Console.WriteLine("");
                    Console.WriteLine("You decided to gather some food together and make dinner.");
                    choice1 = Console.ReadLine().ToLower();
                    Console.Clear();
                    Console.WriteLine("Objective: Make dinner.");
                    Console.WriteLine();
                    Console.WriteLine("Choose which dish you want to make:");
                    Console.WriteLine("Mushrooms, Insects, Berries");
                    Console.WriteLine("");

                    choice = Console.ReadLine().ToLower();
                    Console.Clear();

                    if (choice == "mushrooms")
                    {
                        Console.WriteLine("You are poisoned and you are going to die.");
                        return;
                    }

                    if (choice == "insects")
                    {
                        Console.WriteLine("You gathered some insects and tried your best to cook them. It wasn't the tastiest meal, but it filled your stomachs.");
                        Console.WriteLine("The night was tough as the insects didn't sit well with your stomachs. You had a restless night.");

                        Console.WriteLine("Here is your puzzle/question: What is the capital of Germany?");
                        string answer = Console.ReadLine().ToLower();

                        if (answer == "berlin")
                        {
                            Console.WriteLine("Correct! You have completed the puzzle!");
                            Console.WriteLine("You have completed the game. Congratulations!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer. You didn't survive the night. Game over!");
                            return;
                        }

                        break;
                    }

                    if (choice == "berries")
                    {
                        Console.WriteLine("You are poisoned and you are going to die.");
                        return;
                    }
                    break;
            }
        }
        static string ValidateInput(params string[] validOptions)
        {
            string choice = Console.ReadLine().ToLower();

            while (Array.IndexOf(validOptions, choice) == -1)
            {
                Console.WriteLine("Invalid choice. Choose again!");
                choice = Console.ReadLine().ToLower();
            }

            return choice;

        }
    }
}



