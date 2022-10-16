// using System.Media; //(Importerar System.Media)
// SoundPlayer battle = new SoundPlayer(@""); (SoundPlayer definerar varabeln battle som en "ljudfil")

// Fighter player = new Fighter();
// Fighter enemy = new Fighter();

// player.PlayerChooseName();


// player.Attack(enemy);
// enemy.Attack(player);


// battle.PlayLooping(); (loopar ljudfilen)
// battle.Stop(); (stoppar ljudfilen)
//ladda ner system.windows.extension

Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
//Sätter programmet i "fullscreen"

// screen dimensions: Widht: 174 Height: 43
Console.WriteLine("Not finished becasuse I'm bad at coding :(");
Console.WriteLine("\nUSE FULLSCREEN FOR BEST EXPERIENCE! OTHERWISE STUFF WILL BREAK");
Console.WriteLine("NOTE: All characters belong to their respective copyright owners.");
Console.Write("Press enter to start: ");
Console.ReadLine();
Console.Clear();
Random Generator = new Random();

Console.WriteLine(@"_____________            _______                           
___  __/__  /______      ___    |________________________ _
__  /  __  __ \  _ \     __  /| |_  ___/  _ \_  __ \  __ `/
_  /   _  / / /  __/     _  ___ |  /   /  __/  / / / /_/ / 
/_/    /_/ /_/\___/      /_/  |_/_/    \___//_/ /_/\__,_/  
                                                           ");
Task.Delay(1000).Wait();
Console.WriteLine();
Console.WriteLine(@"_____________________________________
__  ___/__  __/__    |__  __ \__  __/
_____ \__  /  __  /| |_  /_/ /_  /   
____/ /_  /   _  ___ |  _, _/_  /    
/____/ /_/    /_/  |_/_/ |_| /_/     
                                     ");
Task.Delay(750).Wait();
Console.WriteLine(@"                   
 __  __  __  __  \ 
                 / 
                   ");
Console.ReadLine();
Console.Clear();

string confirm_character = "";
int player_char = 0;
int player_MaxHP = 0;
int player_CurrentHP = 0;
int player_speed = 0;
int player_dmg_red = 0;
int player_attack1 = 0;
int player_attack2 = 0;
int player_attack3 = 0;
int player_attack4 = 0;
string[] AttackName = new string[4];
string char_page = "";

Task.Delay(1000).Wait();

while (player_char == 0)
{
    Console.WriteLine(@"______________                                                                    ______                            _____             
    __  ____/__  /_________________________     _____  ___________  _________   _________  /_______ _____________ ________  /_____________
    _  /    __  __ \  __ \  __ \_  ___/  _ \    __  / / /  __ \  / / /_  ___/   _  ___/_  __ \  __ `/_  ___/  __ `/  ___/  __/  _ \_  ___/
    / /___  _  / / / /_/ / /_/ /(__  )/  __/    _  /_/ // /_/ / /_/ /_  /       / /__ _  / / / /_/ /_  /   / /_/ // /__ / /_ /  __/  /    
    \____/  /_/ /_/\____/\____//____/ \___/     _\__, / \____/\__,_/ /_/        \___/ /_/ /_/\__,_/ /_/    \__,_/ \___/ \__/ \___//_/     
                                                /____/                                                                                    ");
    Console.WriteLine("\n");
    while (char_page != "1" && char_page != "2" && char_page != "3" && char_page != "4" && char_page != "5")
    {
        Console.Write("\nChoose a number between 1 and 5: ");
        char_page = Console.ReadLine();
        if (char_page != "1" && char_page != "2" && char_page != "3" && char_page != "4" && char_page != "5")
        {
            Console.WriteLine("\nPlease write one of the acutal numbers.");
        }
    }
    Console.Clear();

    Task.Delay(750).Wait();
    if (char_page == "1")
    {
        Console.WriteLine(@"____________                ______                      _______________
______  /__(_)______ _______ ___  /____  _____________  ____  __/__  __/
___ _  /__  /__  __ `/_  __ `/_  /__  / / /__  __ \  / / /_  /_ __  /_  
/ /_/ / _  / _  /_/ /_  /_/ /_  / _  /_/ /__  /_/ / /_/ /_  __/ _  __/  
\____/  /_/  _\__, / _\__, / /_/  _\__, / _  .___/\__,_/ /_/    /_/     
            /____/  /____/       /____/  /_/                           ");
        Task.Delay(1000).Wait();
        Console.WriteLine("\n");
        Console.WriteLine(@"                         ..                                                                         
                      ..,, . ..                                                                   
                      ..%%%%%&/ ...                                                                
                    ..,%%%%%%%%%. ...      .............                                          
                    ..*%%%%%%%%%%%.........................                                       
                    ..,%%%%%%%%#,.............  ...........,                                      
                    .. %%%%#................    ...........,,.                                    
                    ,...(..................     .........,,,,,......       ....                   
                    ................,,.....    ..,,,,,,,,,,........##%%%%%%%%(*.   .              
                      ,..............,,.....   ..,...................,%%%%%%%%%%%%%#...            
                    ........     .. ..,,...............................%%%%%%%%%%%/ ..             
                  .....,   %##%  ,... ,,,...........,.................,#&%%%%%%*..,               
                  ....,.  %####*  *#(  ..,,,,,,,,,,,,...................,#%%%*...,                 
                  ,....  (###########       .,,,,,... .,    ,,..........,,....,.                   
                ,,,...  *#########%,            ...     (%###(*.......,,,.,,                      
                ,,,,,,.  .%####%#..             .,    ######   (*.....,,,,                        
            ....,,,....*..     ,.......         ,    *###########....,,,,,                        
          ....       ...........................,    .%#########/.,.,,,,,.                        
            ,...... ...............,*............,     %######%,,.,,,,,,,                         
              ,,,.......................,**.........      . ..,,,,,,,,,,                          
                  .,,,,,,,.............................,,,,,,...,,,,,,,,.                          
                    ,,,,,,,,,,..................................,,,,,,,                            
                    .,,,,,,,,,,,,,.......................   ...,,,,,,                             
                      .,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,...    ..,,,,                               
                        ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,...  ..,.                                 
                    .,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.......                                  
                  ......,,,,,****,,,,,,,,,,,,,,,,,,,,,,,,,,...,                                   
                ........,,,,,*****       .....,.***********,,,,,,.                                
                  ,....,,,,,.                      ******,,,,,......                               
                                                      .**,,,,.......,                              
                                                            .,,,,,,.                               ");
        Task.Delay(750).Wait();
        Console.WriteLine("\nA character with all around stats.");
        Task.Delay(750).Wait();
        Console.WriteLine("\n");
        Console.WriteLine(@"____________       _____        
__  ___/_  /______ __  /________
_____ \_  __/  __ `/  __/_  ___/
____/ // /_ / /_/ // /_ _(__  ) 
/____/ \__/ \__,_/ \__/ /____/  
                              ");
        Task.Delay(1000).Wait();
        Console.WriteLine("250 HP");
        Console.WriteLine("\nSpeed: 5");

        Task.Delay(750).Wait();
        Console.WriteLine();
        Console.WriteLine(@"_________________             ______         
___    |_  /__  /______ _________  /_________
__  /| |  __/  __/  __ `/  ___/_  //_/_  ___/
_  ___ / /_ / /_ / /_/ // /__ _  ,<  _(__  ) 
/_/  |_\__/ \__/ \__,_/ \___/ /_/|_| /____/  
                                            ");
        Task.Delay(1000).Wait();
        Console.WriteLine("\nPunch: 20 DMG");
        Console.WriteLine("\nBody slam: 35 DMG");
        Console.WriteLine("\nRoll: 60 DMG");
        Console.WriteLine("\nRest: Restore 40 HP");
        Task.Delay(1000).Wait();

        while (confirm_character != "yes" && confirm_character != "y" && confirm_character != "no" && confirm_character != "n")
        {
            Console.WriteLine("\nPlay as this character?");
            confirm_character = Console.ReadLine().ToLower();
            if (confirm_character != "yes" && confirm_character != "y" && confirm_character != "no" && confirm_character != "n")
            {
                Console.WriteLine("\nJust write yes or no.");
            }
        }
        if (confirm_character == "y" || confirm_character == "yes")
        {
            player_char = 1;
        }
        else if (confirm_character == "n" || confirm_character == "no")
        {
            confirm_character = "";
            char_page = "";
            Console.Clear();
        }
    }

    else if (char_page == "2")
    {
        Console.WriteLine(@"________            ______ _____             ___________  
__  ___/_______________  /____(_)______________  /___  /_ 
_____ \_  _ \__  __ \_  __ \_  /__  ___/  __ \  __/_  __ \
____/ //  __/_  /_/ /  / / /  / _  /   / /_/ / /_ _  / / /
/____/ \___/_  .___//_/ /_//_/  /_/    \____/\__/ /_/ /_/ 
            /_/                                           ");
        Task.Delay(1000).Wait();
        Console.WriteLine("\n");
        Console.WriteLine(@"                                                                      
                                                                *     
                  .(#%(#                                       /*     
                 /%&@&%&/                                      /.     
               @&&@&@@&%        ..(*,,,,,.                    ,,      
            /%&&&&@@@@@&        ,%#((////**                   ,.      
          *%&&&@&@@@@@@@%       .*#/,,(/%%//.                #*       
        ,&%&%&@&&@@@@@@@@&,    .//#@#*/&%%%(//              ,         
      .(%&@&%&&&@@&@@@@@@&@&%##%*@%@%(%%%(,.....,           ,.        
      /%%%@@&&@&@@@@@@@@@@@@@@##%%%/(/##/&.#     *@.       (*         
     /%%%&&@&@@@@@@@@@@@@@@@@&@&%#######%%@%##(/,(/((#(/**#,.         
    ,%%#&&%&@@@@@@@@@@@@@@@@@@#@&&&&@@@&@@@@@@#//%/*****((,****,.     
    #%#@&&@&@&@@@@@@@@@@@@@@@@@@&&%@&@#@@&@@%@@@(##((((((,//,..**,    
   .&#@&%@&@&@@@@@@@@@@@@@@@@@&@@&&&&%&@@@%%%&%@&%%#((/(//(//*/(/,,.  
   /&@&%@%@@&@@@@@@@@@@@@@&@@%%&&@&#@#%&@@@#((%@%%#%(/(#/***,*(/,,(*  
   #&&&@@@@@@@@@@@@@@@@@@%  &@@&&%&&&##%@&@@%###@&%%/(%((((((((*(, *( 
   #&&&%&@@@@@@@@@@@@@@&%  %&@&&%@&&&@##%&&@@*/.#@%%/%*,(*.   ((,*, ,*
  ,%%%%&&&@&&@@@@@@@@&%*  ##&(%%@@&@&&&&#%&&@%   @%((*.   /,   .*.* .,
   %%%%&&&@&@&@@@&@@@%    %#(,%@@@@&@@&&&%%&&@(  &&#&*     ,    ,  .. 
   ##%%%&&&&@&@@@@@%(    ,@&,#@@@&@@@@@&&&%%&@@&/#&%(.     .          
   ###%&%&&&@&&@&,,       &&%%@@@@@@&&&@&&&&&%@@@#%%                  
   ###&&%%@@@&%#            /@@@%%@@@&@&@&&@@&%@%&#%                  
   #(%%&&&@&&&&,            &@@@&@@@@@&#&&&&@@@%%#%%###.              
   ###@%%&&@&(.             (@&%#&@@@@@%%&@@@&..@%##%%%##%%&          
  (#(&&%%&#&#,             .&@@&&&&@@@@&@&&&&@@&@@@&%#%&%%##,         
  (//&%%#&/%*               @&@@&%&@@@@&&&&&&@@@@@@@@&%##%%%          
 /  #%%%%(                  &&@@@&@#@//&&@&%&&&@@@@@@@&&%%##%.        
   ,#((%*                   &&# @@@@@@,@@&@&%&@%&@@@@@@@&&%%,         
   #(/.                    .&&&, %@@@@(@@&&&*  &@@&@@/..              
   ,                         %@%   @@@#@@&&%     @@@@@/               
                             .&@.  .@@&@&&&.         .                
                                ...@@@@@&%%,,,,,,,,,,...............  
                           ....,,,*&&@@@&%%//////////////*****,,,,....
                            ...%&%#%@&%@&%@###############((((///***,,
                                .*//*#%&&%%#(((((((((((((//////****,,,
                                     ,&%%%/......          ........   ");
        Task.Delay(750).Wait();
        Console.WriteLine("\nA fighter with more HP, harder hitting attacks but slower then average");
        Task.Delay(750).Wait();
        Console.WriteLine(@"____________       _____        
__  ___/_  /______ __  /________
_____ \_  __/  __ `/  __/_  ___/
____/ // /_ / /_/ // /_ _(__  ) 
/____/ \__/ \__,_/ \__/ /____/  
                              ");
        Task.Delay(1000).Wait();
        Console.WriteLine("350 HP");
        Console.WriteLine("\nSpeed: 3");

        Task.Delay(750).Wait();
        Console.WriteLine();
        Console.WriteLine(@"_________________             ______         
___    |_  /__  /______ _________  /_________
__  /| |  __/  __/  __ `/  ___/_  //_/_  ___/
_  ___ / /_ / /_ / /_/ // /__ _  ,<  _(__  ) 
/_/  |_\__/ \__/ \__,_/ \___/ /_/|_| /____/  
                                            ");
        Task.Delay(1000).Wait();
        Console.WriteLine("\nSlash: 30 DMG");
        Console.WriteLine("\nShadowflare: Burn for 15 DMG per turn for 5 turns");
        Console.WriteLine("\nOctaslash: 35-90 DMG");
        Console.WriteLine("\nGigaflare: 200 DMG");
        Console.WriteLine("\nPASSIVE: One Winged form");
        Task.Delay(750).Wait();
        Console.WriteLine("When Sephiroth's HP drops below 30%, he gains a flat 10 DMG reduction, higher speed and 15 extra DMG");
        Task.Delay(1000).Wait();

        while (confirm_character != "yes" && confirm_character != "y" && confirm_character != "no" && confirm_character != "n")
        {
            Console.WriteLine("\nPlay as this character?");
            confirm_character = Console.ReadLine().ToLower();
            if (confirm_character != "yes" && confirm_character != "y" && confirm_character != "no" && confirm_character != "n")
            {
                Console.WriteLine("\nJust write yes or no.");
            }
        }
        if (confirm_character == "y" || confirm_character == "yes")
        {
            player_char = 2;
        }
        else if (confirm_character == "n" || confirm_character == "no")
        {
            confirm_character = "";
            char_page = "";
            Console.Clear();
        }


    }
    else if (char_page == "3")
    {
        Console.WriteLine(@"________                     
__  ___/_____ _______________
_____ \_  __ `/_  __ \_  ___/
____/ // /_/ /_  / / /(__  ) 
/____/ \__,_/ /_/ /_//____/  
                             ");
        Task.Delay(1000).Wait();
        Console.WriteLine("\n");
        Console.WriteLine(@"                                                                                                    
                                     @@@@.                @@@@&                                     
                                 @                               @@                                 
                              @%                                   .@@                              
                             @                                        @                             
                           @@                                         @                             
                           @@       @@@@@@@@           /@@@@@@@@       @.                           
                           @@  ,@@@@@@@@@@@@@@        @@@*******@@@    @,                           
                           @@  ,@@@@@@@@@@@@@@        @%****@****@@@   @.                           
                             @   @@@@@@@@@@@@@  %@@    /@@****/@@@@   @                             
                              @%           @   @@@@@@    @          @@                              
                             @      @          @@@@@@         ,@      @                             
                             @   ***@#(**                   **(@@/*   @                             
                             @      @  @ @@@@@@@@@@@@@@@@@@@ @@@      @                             
                          @@@@@%       @@.  @@  %@    @(  @@@       @@@@@@@                         
                       @(,,,,,,,,@          @@@@@@@@@@@@@        @@,,,,,&@###@                      
                      @####@@@@%,,,,,@@@@.                @@@@&,.,,,,,@######@                      
                    @@#########%@,,,,,,,,@@@@@@@@@@@@@@@@@,,,,,,.,,,@@#######@                      
                    @@##############@,,,,,,@          @#,,,,,,*@@@@#####@@#####&@                   
                 &@########@@########@@((@@            /@@@@###########@#########@                  
                @##########@@########@@((@@            /@(@@##########@@############@               
               @###########@@########@@@@@@            /@@@@########@@@@############@               
               @###########@@@@@#######@(((@           ,((@@###@@@@####@#############@%             
               @##########@############@@#(@           ,((@@#@@#########@@###########@%             
                 &@#######@############@(@@@           /@@##@###########@@##########@               
                   #%%%###@#############@#(@           ,(@%%&###########@@#######%((                
                      @###@#############@#(@           ,(@#############@@@#####&@                   
                       @@@@@@@@@########@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@. @                         
                           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@,                           
                           &&&@@@&&&@@@@@@@@@@@@@@@@@@@@@@@@&&&@@@@@@@@@.                           
                          @&&@@@@&&&@@@@@@@@@@@@@@@@@@@@@@@@&&&@@@@@@@@&@@                          
                          @&&@@@&&@@@@@@@@@@@@@&@@&@@@@@@@@@&&&@@@@@@@@&@@                          
                          @&&@@@&&@@@@@@@@@@@@@&@@&@@@@@@@@@&&&&@@@@@@@@&&@                         
                        (@&@@@&&&@@@@@@@@@@@@@&&@@@&&@@@@@@@&&&&@@@@@@@@&&@                         
                        (@&@@@&&&@@@@@@@@@@@@@&@* @&&@@@@@@@@&&&@@@@@@@@&&@                         
                        (@&@@@&&&@@@@@@@@@@@@@&@* @&&@@@@@@@@&&&@@@@@@@@&&@                         
                          @@@@@@@&&&&&&&&&&&&&@    @@&&&&&&&&&&&&&&&@@@@@@                          
                        (@@@@@   @@@@@@                  @  @@@@@@@@    &@@@@                       
                      ,&(,,,,,&&&,     @               .,&         ,@@&&*,,,,&&(,                   
                    @@,,,,,,,,,,,,@@   @               /@        @@,,,,,,,,,,,,,,@                  
                    @@,,,,,,,,,,,,,,@,,,@.            @#,,,,,,,,@,,,,,,,.,,,,,,#@                   ");
        Task.Delay(750).Wait();
        Console.WriteLine("\nTrades some HP for speed.");
        Task.Delay(750).Wait();
        Console.WriteLine("\n");
        Console.WriteLine(@"____________       _____        
__  ___/_  /______ __  /________
_____ \_  __/  __ `/  __/_  ___/
____/ // /_ / /_/ // /_ _(__  ) 
/____/ \__/ \__,_/ \__/ /____/  
                              ");
        Task.Delay(1000).Wait();
        Console.WriteLine("200 HP");
        Console.WriteLine("\nSpeed: 9");

        Task.Delay(750).Wait();
        Console.WriteLine();
        Console.WriteLine(@"_________________             ______         
___    |_  /__  /______ _________  /_________
__  /| |  __/  __/  __ `/  ___/_  //_/_  ___/
_  ___ / /_ / /_ / /_/ // /__ _  ,<  _(__  ) 
/_/  |_\__/ \__/ \__,_/ \___/ /_/|_| /____/  
                                            ");
        Task.Delay(1000).Wait();
        Console.WriteLine("\nWall slam: 25 DMG");
        Console.WriteLine("\nCurse: Apply decay for 5 turns, dealing 20 DMG per turn");
        Console.WriteLine("\nBone Barrage: 25-60 DMG");
        Console.WriteLine("\nMega Blast: 80 DMG");
        Task.Delay(1000).Wait();

        while (confirm_character != "yes" && confirm_character != "y" && confirm_character != "no" && confirm_character != "n")
        {
            Console.WriteLine("\nPlay as this character?");
            confirm_character = Console.ReadLine().ToLower();
            if (confirm_character != "yes" && confirm_character != "y" && confirm_character != "no" && confirm_character != "n")
            {
                Console.WriteLine("\nJust write yes or no.");
            }
        }
        if (confirm_character == "y" || confirm_character == "yes")
        {
            player_char = 3;
        }
        else if (confirm_character == "n" || confirm_character == "no")
        {
            confirm_character = "";
            char_page = "";
            Console.Clear();
        }
    }

    else if (char_page == "4")
    {
        Console.WriteLine(@"________              _____      
___  __ \_____ _________  /_____ 
__  / / /  __ `/_  __ \  __/  _ \
_  /_/ // /_/ /_  / / / /_ /  __/
/_____/ \__,_/ /_/ /_/\__/ \___/ 
                                 ");
        Task.Delay(1000).Wait();
        Console.WriteLine("\n");
        Console.WriteLine(@"                                                  
       ,/ /         ./*.                          
      (#&%       %(((*,.,,,                       
        ,#      &&%/((///(*,.                     
         %%    *&&%/**/((/(#*      #..,(%         
          %%   .&@&(&,,**//%( ./  ,#* &&%         
          ,@#    &@%&#*///(%(/%/@%.               
           *@(    @@&#/*(###&@@%(*                
          &@@@&&%&@&&&%#%@@&@@@@@                 
        ,%&@&#@@#(///##&@@@@@@@@%###/###          
        &*@#&@&%####%%@&*/&&@&&%&&%%%%%##         
       @&@@@@@@@@@@&&&&&/%&&@%&&@&##%%%%##        
      (@%@@@@@&@@@&@@%&&@&&&&#%%#%&&&#%%%%        
       @ @@@@@@@@@@@@&&&&&&&&@%##%&@%%@&%&*       
          %@@@@@@@@@@@&&&&&&&@%##(@@%@@@@&%       
           @@@@@@@@@@&%&&&&&&@%%%#&@@&&&&%%       
           @@@@@@@@@%@&&@&&&&@%%%%%&@@@@%@&%&     
           (@@@@@@@&&@&&@&%&&@@%#%%&%@@@@@&&&#    
            &@@@&@@%@&&&&@&&&&@&%#%&.&@@@@%&%(    
            #@&@@@&@@@@&&&@&&&@&#%%%#  &@&&//,    
           /&&@&@&@@@&@&@@@%&&&@#&&&&   %###*,.   
           %&@&@@@@&@&&&&&@@%#@@@@%%%&   .%#((*   
           #&@@@@@@@@@@@&&((%#@@@@@&&%%    &&#/   
          *##@@@@@@&&&&&&@@&%&&&&@@@&&&&    &@&%  
          %#%@@@@@@&&&@&&@&&%%&&&&@@@&%%    .@&%% 
         .#%@@@@@@@@&&&@@@@@&%%&&@%&@@&&%   &@&@@ 
         ##@@@@@@@@@@@@@@@@@@@@@@@&%&@@%%@  &&@@@@
        .#&@@@@@@@@@&@@@@@@@@@@@@@@@&@@@&@.  (@&@@
        #@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@&@    &&@
       (#&@@@@@@@@@@@@@@@@@@@@@@@@@&@@&@@%@    *%@
      (@(%@@@@@@@@@@@@@@@@@@@@@@@@@@@@&%@@@     &@
     #%(%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&@&     @@
    #&#%&@@@@@@@@@@@@@@&@@@@@@@@@@@@@@&&&&@&    @@
   &&#%@@@@@@@@@@@@@@@@.@@@@@@@@@@@@@@@&&%@&    @@
 %&%%&&%@@@@@@@@@@@@@@@ *@@@@@@@@@@@@@@@@@@@      
%&@&&&@&@@@@@@@@@@@@@@   @@@@@@@@@@@@@@@@@&@&     
@@@@@@   #@@@@@@@@@@@@#  @@@@@@@@@@@@@@@@@@       
   *@,        @@@@@@@@@  *@@@@,  *@@@@@@@@@       
               @@@@@@@@           @@@@@@@@@       
               @@@@@@@@          .@@@@@@@&@       
               #@@&%&@@(          &@@@@@@&#       
              .@@@@@@@@           &@@@&&&&@       
              /@@@@&&@@.          %@@@@@@&@@      
               &@&&%&&&            @@@@@&&@%      
               &@@&@@@@(           @&@@&&%%@      
               .@@&&@@.            (@@@@@@&@      
                &@@@@@@            &@@@@@%&&      
              (&@@@&@@(           (@@@@@@@&&%     
             &@@@&@@,              @@@@@@@@&@@&   
                                        %@@@@@@&&(");
        Task.Delay(750).Wait();
        Console.WriteLine("\nCombo character that relies more on RNG.");
        Task.Delay(750).Wait();
        Console.WriteLine("\n");
        Console.WriteLine(@"____________       _____        
__  ___/_  /______ __  /________
_____ \_  __/  __ `/  __/_  ___/
____/ // /_ / /_/ // /_ _(__  ) 
/____/ \__/ \__,_/ \__/ /____/  
                              ");
        Task.Delay(1000).Wait();
        Console.WriteLine("275 HP");
        Console.WriteLine("\nSpeed: 8");

        Task.Delay(750).Wait();
        Console.WriteLine();
        Console.WriteLine(@"_________________             ______         
___    |_  /__  /______ _________  /_________
__  /| |  __/  __/  __ `/  ___/_  //_/_  ___/
_  ___ / /_ / /_ / /_/ // /__ _  ,<  _(__  ) 
/_/  |_\__/ \__/ \__,_/ \___/ /_/|_| /____/  
                                            ");
        Task.Delay(1000).Wait();
        Console.WriteLine("\nDash: 30 DMG");
        Console.WriteLine("\nRapid Fire: 15-65 DMG");
        Console.WriteLine("\nSword Combo: 30-100 DMG");
        Console.WriteLine("\nSin Devil Trigger: Consume all of your HP to deal 60-150 DMG");
        Task.Delay(1000).Wait();

        while (confirm_character != "yes" && confirm_character != "y" && confirm_character != "no" && confirm_character != "n")
        {
            Console.WriteLine("\nPlay as this character?");
            confirm_character = Console.ReadLine().ToLower();
            if (confirm_character != "yes" && confirm_character != "y" && confirm_character != "no" && confirm_character != "n")
            {
                Console.WriteLine("\nJust write yes or no.");
            }
        }
        if (confirm_character == "y" || confirm_character == "yes")
        {
            player_char = 4;
        }
        else if (confirm_character == "n" || confirm_character == "no")
        {
            confirm_character = "";
            char_page = "";
            Console.Clear();
        }
    }

    else
    {
        Console.WriteLine(@"________      ______             ______ __      _____        ______ _____ 
___  __/___  ____  /_______ _    ___  //_/_________(_)______ ___  /___  /_
__  /  _  / / /_  __ \  __ `/    __  ,<  __  __ \_  /__  __ `/_  __ \  __/
_  /   / /_/ /_  /_/ / /_/ /     _  /| | _  / / /  / _  /_/ /_  / / / /_  
/_/    \__,_/ /_.___/\__,_/      /_/ |_| /_/ /_//_/  _\__, / /_/ /_/\__/  
                                                     /____/               ");
        Task.Delay(1000).Wait();
        Console.WriteLine("\n");
        Console.WriteLine(@"                                                                                
                                                                                
                                                                                
                          (*                                                    
                         **,                                                    
                         //                                                     
                        **.                                                     
                        */                                                      
                       **.           /((*,. .                                   
                      ,,*           /%/,,*,,*,**(                               
                      ,/           .(/*.,*./***#%.                              
                     ,*.           #,*,..,./,,/%(                               
                     **           (**..., ,/,,/%(                               
                    **.          ./,*../,.**.,/%#                               
                    .,           *//,..*,.,*,,*(&(,***...,*/((%*                
                   **            *,*,..**,,*,,*/#%(%%%#%######%%#(              
                  .,*            **/*,,&/#**,,,***#%%%%%%%%%%#%((%,             
                  ./              #(/*/(%&&*/*(,,*/(#######((((***.             
                 .*/              */(//(&%,,*,,***//***,******.,,*.             
                 **             ,#/#/%%%*(/#/#/..*/.           ...              
                ,(,           .#####(/(/,,,(*..               ,.                
              .*,/,          ,######*((/*,....,*(//,... .     @&.               
             ,,. #*,     .. .#(###(#(/(,.. .,, ,**/**,**,,.,&@%%/               
             *,..//         .(##((*(#((/, ,,,%/(/*////*/*@@@&&&&#.              
             .*#*          .*/*/(/(////**,*,****#*%**&@@@@&&(%#(/#&,            
             ./*                /((((/////(,/,//,%*#,(@@@@@%#&#%@&#(            
                                *(,(,(%#*,*.%/*(*(,%/#*(#%(#((((#%(#,           
                                 /#*/**&(@((#*((,##(*.*/(.#/((%#%&#             
                                 ,%##,.*#&@ ./ ,...&***..%(**%&(                
                              ./,.*(% /##(/%/&&@&(&**%((/&/&##,/,               
                             ,%//*,#((@@@#(%(&%/%&#%*&&(%#,&@%%#*,*             
                            ,,*(#%%##*,&%%(#%%#%#%%%##((&%(#(// /((,(,          
                                  ,%%%((,*&&&/#(%*(@&&%(#,./%/#%(.,/#,#,        
                                   ,@&#%%%*,#&@@&./((&@@@#*&@#%/(,  .##/*       
                                   &@@@@&###(**%%&%*(%*#@@@%/#.      &%##.      
                                  #@@@@@@@@%##%/*%%%@#*(#*#%/.      ##%#%       
                                 (@@@@@@@@@* (%#%%//#%(%#*@%     ,%(*#(%.       
                                (@@@@@@@@@%    #@%##(**/%%&&#/%%#*(#(&,         
                                &@@@@@@@@@/    ,&@@@%(##***..,*####.            
                                %@@@@@@@@@/     #@@@@@@@@&%((/,                 
                                .&@@@@@@@@%      &@@@@@@@@,                     
                                 .&@@@@@@@@#     #@@@@@@@@%                     
                                   &@@@@@@@@#    (&&&&&&&&&                     
                                    %@@@@@@@@%   .&&&&&&&&&.                    
                                    .&@@@@@@@@*   &&&&&&&&&#                    
                                  .%&%%@@@@@@&%.  #&&&&&&&@&,                   
                               ,//(//(#%%&@%%%/   .&&&@&&&&&(                   
                              .(///#(//.           %&&&&&&&&%                   
                                                   /&&&&&&&&&*                  
                                                   .&&&&&&&&&(                  ");
        Task.Delay(750).Wait();
        Console.WriteLine("\nDefensive character that can block attacks");
        Task.Delay(750).Wait();
        Console.WriteLine("\n");
        Console.WriteLine(@"____________       _____        
__  ___/_  /______ __  /________
_____ \_  __/  __ `/  __/_  ___/
____/ // /_ / /_/ // /_ _(__  ) 
/____/ \__/ \__,_/ \__/ /____/  
                              ");
        Task.Delay(1000).Wait();
        Console.WriteLine("250 HP");
        Console.WriteLine("\nSpeed: 6");

        Task.Delay(750).Wait();
        Console.WriteLine();
        Console.WriteLine(@"_________________             ______         
___    |_  /__  /______ _________  /_________
__  /| |  __/  __/  __ `/  ___/_  //_/_  ___/
_  ___ / /_ / /_ / /_/ // /__ _  ,<  _(__  ) 
/_/  |_\__/ \__/ \__,_/ \___/ /_/|_| /____/  
                                            ");
        Task.Delay(1000).Wait();
        Console.WriteLine("\nFlute Slash: 35 DMG");
        Console.WriteLine("\nBlock: Raise the Tuba Shield to block an incoming attack.");
        Console.WriteLine("\nChord: Increase attack by 10 DMG");
        Console.WriteLine("\nChorus: Summon a quire, dealing 100 DMG");
        Task.Delay(1000).Wait();

        while (confirm_character != "yes" && confirm_character != "y" && confirm_character != "no" && confirm_character != "n")
        {
            Console.WriteLine("\nPlay as this character?");
            confirm_character = Console.ReadLine().ToLower();
            if (confirm_character != "yes" && confirm_character != "y" && confirm_character != "no" && confirm_character != "n")
            {
                Console.WriteLine("\nJust write yes or no.");
            }
        }
        if (confirm_character == "y" || confirm_character == "yes")
        {
            player_char = 5;
        }
        else if (confirm_character == "n" || confirm_character == "no")
        {
            confirm_character = "";
            char_page = "";
            Console.Clear();
        }
    }


}

Console.Clear();
int[] array_hp = { 250, 350, 200, 275, 250 };
int[] array_attack1 = { 20, 30, 20, 30, 20 };
int[] array_attack2 = { };

if (player_char == 1)
{
    player_MaxHP = 250;
    player_CurrentHP = player_MaxHP;
    player_speed = 5;
    player_dmg_red = 0;
    player_attack1 = 20;
    player_attack2 = 35;
    player_attack3 = 60;
    player_attack4 = player_CurrentHP += 40;
    if (player_MaxHP - player_CurrentHP < 40)
    {
        player_attack4 = player_CurrentHP += player_MaxHP - player_CurrentHP;
    }
    else
    {
        player_attack4 = player_CurrentHP += 40;
    }
}

else if (player_char == 2)
{
    player_MaxHP = 350;
    player_speed = 3;
    player_dmg_red = 0;
    player_attack1 = 30;
    player_attack2 = 0;
    player_attack3 = Generator.Next(35, 91);
    player_attack4 = 200;
    // while (player_hp < 105)
    // {
    //     player_speed = 7;
    //     player_dmg_red = 10;
    //     player_attack1 = 45;
    //     player_attack2 = 0;
    //     player_attack3 = Generator.Next(50, 106);
    //     player_attack4 = 215;
    // }

}

else if (player_char == 3)
{
    player_MaxHP = 200;
    player_speed = 9;
    player_dmg_red = 0;
    player_attack1 = 20;
    player_attack2 = 25;
    player_attack3 = Generator.Next(25, 61);
    player_attack4 = 80;
}

else if (player_char == 4)
{
    player_MaxHP = 275;
    player_speed = 8;
    player_dmg_red = 0;
    player_attack1 = 30;
    player_attack2 = Generator.Next(15, 66);
    player_attack3 = Generator.Next(30, 101);
    player_attack4 = Generator.Next(60, 151);
}

else
{
    int chord_buff = 10;
    int bonus_dmg = chord_buff * player_attack3;
    player_MaxHP = 250;
    player_speed = 6;
    player_dmg_red = 0;
    player_attack1 = 20 + bonus_dmg;
    player_attack2 = Generator.Next(1, 101);
    player_attack3 += 1;
    player_attack4 = 100 + bonus_dmg;
}


// Enemy
int enemy_player = Generator.Next(1, 5);
int enemy_hp = 0;
int enemy_speed = 0;
int enemy_dmg_red = 0;
int enemy_attack1 = 0;
int enemy_attack2 = 0;
int enemy_attack3 = 0;
int enemy_attack4 = 0;


Console.WriteLine("Selecting opponent");
Task.Delay(2000).Wait();
(enemy_hp, enemy_attack1, enemy_speed) = Challanger(enemy_player); //funktion som bestämmer hp, skada och hastighet av fiendet
int enemy_maxHP = enemy_hp;
while (enemy_player == player_char)
{
    enemy_player = Generator.Next(1, 5);
}
Task.Delay(750).Wait();

//Eftersom det skulle för komplicerad att göra allt med funktioner och klasser
//så kommer jag ha massa if satser för att definera de andra attackerna. 
//Därför kommer du behöva stå ut med den här fula koden.
//Som man brukar säga: "If it ain't broken, don't fix it."

if (enemy_player == 1)
{
    enemy_attack2 = 35;
    enemy_attack3 = 60;
    enemy_attack4 = enemy_hp += 40;
}

else if (enemy_player == 2)
{
    enemy_attack2 = Generator.Next(35, 91);
    enemy_attack3 = 0;
    enemy_attack4 = 200;
}

else if (enemy_player == 3)
{
    enemy_attack2 = 25;
    enemy_attack3 = Generator.Next(25, 61);
    enemy_attack4 = 80;
}

else if (enemy_player == 4)
{
    enemy_attack2 = Generator.Next(15, 66);
    enemy_attack3 = Generator.Next(30, 101);
    enemy_attack4 = Generator.Next(60, 151);
}

else
{
    int chord_buff = 10;
    int bonus_dmg = chord_buff * enemy_attack3;
    enemy_attack2 = Generator.Next(1, 101);
    enemy_attack3 += 1;
    enemy_attack4 = 100 + bonus_dmg;
}

Task.Delay(750).Wait();
Console.WriteLine("Battle starts in:");
Task.Delay(1500).Wait();
Console.WriteLine(@"________
__|__  /
___/_ < 
____/ / 
/____/  
        ");
Task.Delay(1000).Wait();
Console.WriteLine(@"______ 
__|__ \
____/ /
_  __/ 
/____/ 
       ");
Task.Delay(1000).Wait();
Console.WriteLine(@"______
__<  /
__  / 
_  /  
/_/   
      ");
Task.Delay(1000).Wait();
Console.Clear();

//UI och combat

while (player_MaxHP > 0 && enemy_hp > 0)
{
    HPbar(5, 10, player_MaxHP, player_CurrentHP);
    HPbar(65, 10, enemy_maxHP, enemy_hp);
    MenuLine();
    string[] attacks = PlayerAttacks();
    Menu(attacks);
    Console.ReadLine();
}


//static void gör som en separat fil som har egen information
//bara void låter dig använda namnet av variablar från tidigare

//Plats för static void saker

string[] PlayerAttacks() //Namnger attackerna beroende på karaktär så att det är mer tydligt vilken attack man använder
{
    string[] Attacks1 = { "Punch", "Body Slam", "Roll", "Rest" };
    string[] Attacks2 = { "Slash", "Shadowflare", "Octaslash", "Gigaflare" };
    string[] Attacks3 = { "Wall Slam", "Curse", "Bone Barrage", "Mega Blast" };
    string[] Attacks4 = { "Dash", "Rapid Fire", "Sword Combo", "Sin Devil Trigger" };
    string[] Attacks5 = { "Flute Slash", "Block", "Chord", "Chorus" };
    Array[] Attacks = { Attacks1, Attacks2, Attacks3, Attacks4, Attacks5 }; //Lägger alla attack arrays i en stor array
    string[] AttackName = (string[])Attacks[player_char - 1]; //väljer namnen för attackerna utifrån vem man kör
    // Console.SetCursorPosition(4, 41);
    // Console.Write($"{AttackName[0]}   ");
    // Console.Write($"{AttackName[1]}   ");
    // Console.Write($"{AttackName[2]}   ");
    // Console.Write($"{AttackName[3]}   ");

    return AttackName;
    //Console.ReadLine();
}

static (int, int, int) Challanger(int enemy_player)
{

    string[] opponent = { "Jigglypuff", "Sephiroth", "Sans", "Dante", "Tuba Knight" };
    Console.Write("Your opponent is: ");
    Task.Delay(1000).Wait();
    Console.WriteLine(opponent[enemy_player]);
    int[] array_hp = { 250, 350, 200, 275, 250 };
    int[] array_dmg1 = { 20, 30, 25, 30, 20 };
    int[] array_speed = { 5, 3, 9, 8, 6 };
    return (array_hp[enemy_player], array_dmg1[enemy_player], array_speed[enemy_player]);

    // return enemy_hp;
    //Console.WriteLine(enemy_hp);

}

static void HPbar(float x, float y, int MaxHP, int CurrentHP)
// CurrentHP/MaxHP *45 ger hur mycket hp man har kvar i procent
{
    x = Console.WindowWidth * (x / 100);
    y = Console.WindowHeight * (y / 100);
    Console.SetCursorPosition((int)x, (int)y);
    Console.Write("<");
    for (var i = 0; i < Console.WindowWidth * 0.25; i++) // i är längden på hp bar, den ska fortsätta expandera tills den är 45 pixlar
    // när CurrentHP är mindre än i (45) så kommer delen som saknas färgas röd. 
    {
        if (CurrentHP > i)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        Console.Write("█");
    }
    Console.ResetColor();
    Console.SetCursorPosition((int)x + 45, (int)y);
    Console.WriteLine($">{CurrentHP}/{MaxHP}  ");
}

static void MenuLine()
{
    Console.SetCursorPosition(0, 39);
    for (var i = 0; i < Console.WindowWidth; i++)
    {
        Console.Write("-");
    }
}

void Menu(string[] AttackName)
{
    int choice = 0;
    while (true)
    {
        Console.SetCursorPosition(1, 42);
        Console.Write($"{AttackName[0]}");
        Console.SetCursorPosition((int)(Console.WindowWidth * 0.25) + 1, 42);
        Console.Write($"{AttackName[1]}");
        Console.SetCursorPosition((int)(Console.WindowWidth * 0.5) + 1, 42);
        Console.Write($"{AttackName[2]}");
        Console.SetCursorPosition((int)(Console.WindowWidth * 0.75) + 1, 42);
        Console.Write($"{AttackName[3]}");
        Console.SetCursorPosition(choice * (int)(Console.WindowWidth * 0.25), 42);

        Console.Write(">");
        var key = Console.ReadKey(true);   //readkey är som readline men reagerar direkt när man trycker istället för bara enter
        if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D && choice < 3)  //true gör så att man inte ritar det man skriver
        {
            choice++;
        }
        else if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A && choice > 0)
        {
            choice--;
        }
        else if (key.Key == ConsoleKey.Enter)
        {
            // switch (choice)
            // {
            //     case 0:
            //     attack = attack1
            //        
            // }

        }
    }

}


// static int Remap(float value, int from1, int to1, int from2, int to2 )
// {
//     return ()
// }


// void combat()
// {
//     player_attack1
// }

Console.WriteLine("It works");
Console.ReadLine();
//174 43 px