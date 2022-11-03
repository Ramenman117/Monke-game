using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Diagnostics;
    
public class balls
{
    public static void PileNumber()
    {
        Random random = new Random();
        int rannumber = random.Next(2, 2000);
        Console.Write(rannumber);
    }
    public static void PileNumber2()
    {
        Random random = new Random();
        int rannumber = random.Next(2, 100);
        Console.Write(rannumber);
    }


    public static void Main(string[] args)
    {
        Stopwatch monkewatch = new Stopwatch();
        int time = 1000;
        egg: bool monke = true;
        while (monke == true)
        {
            Console.WriteLine("Quick! choose 1 or 2 there is no time to explain just pick!");
            int answer = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");
            //Console.ForegroundColor = ConsoleColor.;
            //Console.BackgroundColor = ConsoleColor.;
            switch (answer)
            {
                case 1:
                    Console.WriteLine("you hear a whooshing sound.");
                    Console.WriteLine("you find your self in a forest press 1 to go forward 2 to go left and 3 to go right.");
                    int answer1 = Convert.ToInt32(Console.ReadLine());
                    switch (answer1)
                    {
                        case 1:

                            Console.WriteLine("             ^                             ");
                            Console.WriteLine("            / \\                                 ");
                            Console.WriteLine("           /| |\\                                ");
                            Console.WriteLine("          //| |\\\\                        ");
                            Console.WriteLine("         ///| |\\\\\\                       ");
                            Console.WriteLine("        ////| |\\\\\\\\                        ");
                            Console.WriteLine("       /////| |\\\\\\\\\\                      ");
                            Console.WriteLine("      //////| |\\\\\\\\\\\\                      ");
                            Console.WriteLine("           || ||                             ");
                            Console.WriteLine("           |   |                                 ");
                            Console.WriteLine("          ||   ||                         ");
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("You find yourself pushing through the dense foliage.");
                            Console.WriteLine("you are crawling under a bush when you find a broken sword.");
                            Console.WriteLine("Pick up the sword? 1. leave the sword? 2.");
                            int answer2 = Convert.ToInt32(Console.ReadLine());
                            switch (answer2)
                            {
                                case 1:
                                    Console.WriteLine("you pick up the sword.");
                                    Console.WriteLine("it starts to shake and glow");
                                    Console.WriteLine("you hear somthing in the back of your head that you can't understand but its driving you insane");
                                    Console.WriteLine("You cant take it anymore you throw your head back in a scream");
                                    Thread.Sleep(time);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("As you scream you turn the sword around and plunge it into your abdomen");
                                    Thread.Sleep(time);
                                    Console.WriteLine("The Forest Takes another victim...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    monke = false;
                                    

                                    break;
                                case 2:
                                    Console.WriteLine("you resist the urge to pick it up and keep crawling forward");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("you fall into a pit of ");
                                    PileNumber();
                                    Console.Write(" swords");
                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    monke = false;
                                    
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("you go left");
                            Console.WriteLine("you see a village in the distance");
                            Console.WriteLine("you move towards the villge and you realize its a castle");
                            Console.WriteLine("as you get close they train their Ballista on you");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("you realize at the last moment that they are filled with swords");
                            Console.WriteLine("You only realize this though as soon as your abdomen gets impaled by a 12 foot long sword");
                            Console.ForegroundColor = ConsoleColor.White;
                            monke = false;
                            
                            break;

                        case 3:
                            Console.WriteLine("You turn right and see a light far off in the distance");
                            Console.WriteLine("Finally you think");
                            Console.WriteLine("a way out");
                            Thread.Sleep(time);
                            Console.WriteLine("you start running and you hear something chasing you");
                            Console.WriteLine("fighting againt all instinct to turn around");
                            Thread.Sleep(time);
                            Console.WriteLine("Your legs start to pound faster and faster");
                            Console.WriteLine("You hear it getting closer and closer");
                            Thread.Sleep(time);
                            Console.WriteLine("You can feel the thing breath on your neck");
                            Console.WriteLine("You are getting closer and closer to the light");
                            Console.WriteLine("you can't help but let the tears go that have been collecting in your eyes");
                            Thread.Sleep(time);
                            Console.WriteLine("you dont want to be alone anymore");
                            Thread.Sleep(time);
                            Console.WriteLine("you reach the blinding light and you dive through it");
                            Thread.Sleep(time);
                            Console.WriteLine("The noises from the thing stopped");
                            Thread.Sleep(time);
                            Console.WriteLine("You find yourself in the middle of a field surrounded by the Forest");
                            Console.WriteLine("In the middle of it you see a hobbit house wit the lights on");
                            egg2:
                            Console.WriteLine("Do you knock? 1 or do you leave? 2");
                            int answer3 = Convert.ToInt32(Console.ReadLine());
                                switch (answer3)
                            {
                                case 1:
                                    Console.WriteLine("You knock on the door");
                                    Console.WriteLine("you hear something shuffling inside");
                                    Console.WriteLine("''Give me a minute!''");
                                    Console.WriteLine("Timer");
                                     Console.WriteLine("60");
                                     Thread.Sleep(time);
                                     Console.WriteLine("59");
                                     Thread.Sleep(time);
                                     Console.WriteLine("58");
                                     Thread.Sleep(time);
                                     Console.WriteLine("57");
                                     Thread.Sleep(time);
                                     Console.WriteLine("56");
                                     Thread.Sleep(time);
                                     Console.WriteLine("55");
                                     Thread.Sleep(time);
                                     Console.WriteLine("54");
                                     Thread.Sleep(time);
                                     Console.WriteLine("54");
                                     Thread.Sleep(time);
                                     Console.WriteLine("53");
                                     Thread.Sleep(time);
                                     Console.WriteLine("52");
                                     Thread.Sleep(time);
                                     Console.WriteLine("51");
                                     Thread.Sleep(time);
                                     Console.WriteLine("50");
                                     Thread.Sleep(time);
                                     Console.WriteLine("49");
                                     Thread.Sleep(time);
                                     Console.WriteLine("48");
                                     Thread.Sleep(time);
                                     Console.WriteLine("47");
                                     Thread.Sleep(time);
                                     Console.WriteLine("46");
                                     Thread.Sleep(time);
                                     Console.WriteLine("45");
                                     Thread.Sleep(time);
                                     Console.WriteLine("44");
                                     Thread.Sleep(time);
                                     Console.WriteLine("43");
                                     Thread.Sleep(time);
                                     Console.WriteLine("42");
                                     Thread.Sleep(time);
                                     Console.WriteLine("41");
                                     Thread.Sleep(time);
                                     Console.WriteLine("40");
                                     Thread.Sleep(time);
                                     Console.WriteLine("39");
                                     Thread.Sleep(time);
                                     Console.WriteLine("38");
                                     Thread.Sleep(time);
                                     Console.WriteLine("37");
                                     Thread.Sleep(time);
                                     Console.WriteLine("36");
                                     Thread.Sleep(time);
                                     Console.WriteLine("35");
                                     Thread.Sleep(time);
                                     Console.WriteLine("34");
                                     Thread.Sleep(time);
                                     Console.WriteLine("33");
                                     Thread.Sleep(time);
                                     Console.WriteLine("32");
                                     Thread.Sleep(time);
                                     Console.WriteLine("31");
                                     Thread.Sleep(time);
                                     Console.WriteLine("30");
                                     Thread.Sleep(time);
                                     Console.WriteLine("29");
                                     Thread.Sleep(time);
                                     Console.WriteLine("28");
                                     Thread.Sleep(time);
                                     Console.WriteLine("27");
                                     Thread.Sleep(time);
                                     Console.WriteLine("26");
                                     Thread.Sleep(time);
                                     Console.WriteLine("25");
                                     Thread.Sleep(time);
                                     Console.WriteLine("24");
                                     Thread.Sleep(time);
                                     Console.WriteLine("23");
                                     Thread.Sleep(time);
                                     Console.WriteLine("22");
                                     Thread.Sleep(time);
                                     Console.WriteLine("21");
                                     Thread.Sleep(time);
                                     Console.WriteLine("20");
                                     Thread.Sleep(time);
                                     Console.WriteLine("19");
                                     Thread.Sleep(time);
                                     Console.WriteLine("18");
                                     Thread.Sleep(time);
                                     Console.WriteLine("17");
                                     Thread.Sleep(time);
                                     Console.WriteLine("16");
                                     Thread.Sleep(time);
                                     Console.WriteLine("15");
                                     Thread.Sleep(time);
                                     Console.WriteLine("14");
                                     Thread.Sleep(time);
                                     Console.WriteLine("13");
                                     Thread.Sleep(time);
                                     Console.WriteLine("12");
                                     Thread.Sleep(time);
                                     Console.WriteLine("11");
                                     Thread.Sleep(time);
                                     Console.WriteLine("10");
                                     Thread.Sleep(time);
                                     Console.WriteLine("9");
                                     Thread.Sleep(time);
                                     Console.WriteLine("8");
                                     Thread.Sleep(time);
                                     Console.WriteLine("7");
                                     Thread.Sleep(time);
                                     Console.WriteLine("6");
                                     Thread.Sleep(time);
                                     Console.WriteLine("5");
                                     Thread.Sleep(time);
                                     Console.WriteLine("4");
                                     Thread.Sleep(time);
                                     Console.WriteLine("3");
                                     Thread.Sleep(time);
                                     Console.WriteLine("2");
                                     Thread.Sleep(time);
                                     Console.WriteLine("1");
                                     Thread.Sleep(time);
                                    Console.WriteLine("''Thanks for waiting!''");
                                    Console.WriteLine("You hear several locks being undone");
                                    Console.WriteLine("The door slowly opens");
                                    Console.WriteLine("''Hello!''");
                                    Console.WriteLine("It was a strage sight");
                                    Console.WriteLine("It was a humanoid figure in a dark cloak and thick black gloves with white shining eyes.");
                                    Console.WriteLine("''Come in come in!''");
                                    Console.WriteLine("You follow it inside");
                                    Console.WriteLine("it has a nice cozy house");
                                    Console.WriteLine("''sit down i will get us some food''");
                                    Console.WriteLine("you hear it walking in the kitchen and its humming to its self");
                                    Console.WriteLine("the tune sounds familiar");
                                    Console.WriteLine("https://www.youtube.com/watch?v=6AVRCQBc59w");
                                    Console.WriteLine("it walks back in with 2 wooden plates");
                                    Console.WriteLine("its cooked squirrel");
                                    Console.WriteLine("it seems to have been stabbed to death right in the stomach");
                                    Console.WriteLine("''after we eat you can stay here for the night and then I will escort you out of here tomorrow''");
                                    Console.WriteLine("you finish the food it was very good");
                                    Console.WriteLine("you get up and ask ''where is the bathroom?''");
                                    Console.WriteLine("''follow me'' it replys");
                                    Console.WriteLine("you follw it down the hallway to the bathroom");
                                    Console.WriteLine("''here is the bathroom, just dont open the cabinet''");
                                    Console.WriteLine("''ok''");
                                    Console.WriteLine("you close the door");
                                    Console.WriteLine("open the cabinet (1) leave the cabinet alone (2)");
                                    int answer4 = Convert.ToInt32(Console.ReadLine());
                                    switch(answer4)
                                    {
                                        case 1:
                                            Console.WriteLine("you decide to open the cabinet");
                                            Console.WriteLine("inside you see something horrifiing");
                                            Console.WriteLine("the nice man");
                                            Thread.Sleep(time);
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("had no skin");
                                            Console.WriteLine("you cant help but let out a blood curdiling scream");
                                            Console.WriteLine("you hear the man running down the hallway screaming hes sorry");
                                            Console.WriteLine("he slams the door open you see tears streeming down his face");
                                            Console.WriteLine("his gloves are off and you see that his fingers");
                                            Console.WriteLine("are knives");
                                            Console.WriteLine("he screams hes sorry as he digs his daggers into your chest and neck");
                                            Console.WriteLine("Hes saying sorry and crying and slowly the world turns black.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            monke = false;
                                            break;
                                        case 2:
                                            Console.WriteLine("you deicide against opening it");
                                            Console.WriteLine("you use the bathroom and as you walk out it motions to you");
                                            Console.WriteLine("you walk over and it has turned its couch into a bed");
                                            Console.WriteLine("''you can sleep here and we leave at dawn''");
                                            Console.WriteLine("you fall asleep instantly");
                                            Console.WriteLine("you wake to the smell of coffee and bacon");
                                            Console.WriteLine("you stretch and yawn");
                                            Console.WriteLine("You walk into the kitchen and sit at the table");
                                            Console.WriteLine("just as you sit down it rushes over and hands you a wooden plate with bacon and eggs with a cup of coffe");
                                            Console.WriteLine("after you eat you both head outside");
                                            Console.WriteLine("after a walk of about 3 hours you find a temple and the thing wishes you well");
                                            Console.WriteLine("then you walk inside and hear the same whooshing sound from when you entered the forest.");
                                            Console.WriteLine("the end?");
                                            monke = false;
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("you cant move your legs");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    goto egg2;
                                    
                            }
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("you hear a whooshing sound.");
                    Console.WriteLine("You find yourself in the middle of a trench in military greens");
                    Console.WriteLine("you hear Airsoft gun fire all around you");
                    Console.WriteLine("the path branched to the left right and forward is the trench");
                    Console.WriteLine("do you go left or right or forward?");
                    string leftorright = Console.ReadLine();
                    if (leftorright == "left")
                    {
                        Console.WriteLine("you turn to your left and start walking down the trench");
                        Console.WriteLine("You realize you have no weapon so instinctivly you pick up a airsoft handgun and check the ammo");
                        Console.WriteLine("the ammo is full");
                        Console.WriteLine("you see some people with the same uinforms as you");
                        Console.WriteLine("''Hey'' someone says to you");
                        Console.WriteLine("you give him a nod");
                        Console.WriteLine("you hear shout from behind you and everyone turns that way");
                        Console.WriteLine("The people running to you are wearing diffrent uniforms then you");
                        Console.WriteLine("You dive behind cover and shoot 4 shots and hit 2");
                        Console.WriteLine("''FALL BACK''");
                        Console.WriteLine("you turn and run");
                        Console.WriteLine("you keep running and turn left its a dead end and they are right behind you");
                        Console.WriteLine("surrender?");
                        string surrender = Console.ReadLine();
                        if (surrender == "yes")
                        {
                            Console.WriteLine("you put your airsoft gun down and raise your hands");
                            Console.WriteLine("they shoot you");
                            monke = false;
                        }
                        else
                        {
                            Console.WriteLine("you keep running at the wall and launch your self at it");
                            Console.WriteLine("you do a backflip off the wall and ninja kick the guy");
                            Console.WriteLine("then you land on him and shoot the other 2");
                            Console.WriteLine("you run down the other way");
                            Console.WriteLine("you re join with the rest or your platoon");
                            Console.WriteLine("''LISTEN UP, WE ARE EVACING IN 3 MINUTES, WE ARE SURROUNDED SO HOLD YOUR GROUND''");
                                Console.WriteLine("You start running around looking for a good place to set up");
                                Console.WriteLine("you find a new airsoft rifle");
                                Console.WriteLine("do you want to set up in the tower, the bunker, or the sun");
                            string setup = Console.ReadLine();
                            if (setup == "tower")
                            {
                                Console.WriteLine("you climb up the ladder to the tower");
                                Console.WriteLine("you get into a good postion and start firing plastic BB's at the enemy");
                                Console.WriteLine("after a few munites you start to hear the hellicopters and a few minutes later you get on one and evac");
                                monke=false;
                            }
                            else if ( setup == "bunker")
                            {
                                Console.WriteLine("you climb down into the bunker");
                                Console.WriteLine("you get into a good postion and start firing plastic BB's at the enemy");
                                Console.WriteLine("after a few munites you start to hear the hellicopters and a few minutes later you get on one and evac");
                                monke=false;
                            }
                            else
                            {
                                Console.WriteLine("you climb into a rocket and take off directly into the sun for some reason");
                                monke=false;

                            }
                        }


                    }
                    else if (leftorright == "forward")
                    {
                        Console.WriteLine("you decide for some stupid reason to climb out of the trench");
                        Console.WriteLine("as you get out you hear someone behind you");
                        Console.WriteLine("''GET BACK HERE PRIVATE''");
                        Console.WriteLine("you decide to keep going forward into no mans land");
                        Console.Write("you then get shot ");
                        PileNumber2();
                        Console.Write(" times by BB's");
                        Console.WriteLine(" ");
                        monke = false;
                    }
                    else
                    {
                        Console.WriteLine("you turn to your left and start running down the trench");
                        Console.WriteLine("the further you go down the trench the more knocked out people you see");
                        Console.WriteLine("You realize you have no weapon so instinctivly you pick up a airsoft handgun and check the ammo");
                        Console.WriteLine("its 3/4 full");
                        Console.WriteLine("do you want to reload?");
                        string reload = Console.ReadLine();
                        if(reload == "yes")
                        {
                            Console.WriteLine("You scrounge around on the ground and find some more ammo and reload your airsoft gun");
                            Console.WriteLine("you keep heading down the trench");
                            Console.WriteLine("you hear shouting ahead");
                            Console.WriteLine("you run into some people and realize they are the enemy");
                            Console.WriteLine("you pull the trigger but nothing happens");
                            Console.WriteLine("you must have jammed it when realoding");
                            Console.WriteLine("the three of them fire at you");
                            Console.WriteLine("you fall over and hit your head and blackout");
                            monke = false;
                        }
                        else
                        {
                            Console.WriteLine("you decide to not reload and kepp running");
                            Console.WriteLine("you run into 3 guys and see that they are the enemy");
                            Console.WriteLine("you open fire while diving behind cover");
                            Console.WriteLine("you shot one");
                            Console.WriteLine("you look out from cover");
                            Console.WriteLine("do you want to rush in or fall back?");
                            string runorfight = Console.ReadLine();
                            if(runorfight == "rush in" || runorfight == "run in")
                            {
                                Console.WriteLine("you break out from cover and run in");
                                Console.WriteLine("you realize that was very stupid as you get hit by BB's fall and passout");
                                monke=false;
                            }
                            else
                            {
                                Console.WriteLine("you decide you fall back");
                                Console.WriteLine("as you are running away you hear shouts behind you");
                                Console.WriteLine("you turn to see the other 2 guys following you");
                                Console.WriteLine("you quickly turn and shoot the 2 guys while running");
                                Console.WriteLine("you run into a wall and get concussed");
                                monke=false;
                            }
                        }
                    }

                    break;
            }


        }
        

        Console.WriteLine("do you want to restart?");
        string restart = Console.ReadLine();
        if (restart == "yes")
        {
            monke = true;
            Console.Clear();
            goto egg;
        }
        else
        {
            Console.WriteLine("Stupid Monke rage quit");
            Environment.Exit(0);
        }
    }
}

//Console.WriteLine("");
//Console.ForegroundColor = ConsoleColor.;
//Console.BackgroundColor = ConsoleColor.;

/*public string GradeCalculator(float input)
{
    if (input < 60)
    {
        return "F";
    }
    else if (input < 70)
    {
        return "D";
    }
    else if (input < 80)
    {
        return "C";

    }
    else if (input < 90)
    {
        return "B";
    }
    else
    {
        return "A";
    }
}
*/

/*
monke = false;
goto egg;
*/