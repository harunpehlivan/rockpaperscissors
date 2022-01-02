using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //restart value
    bool restart = true;

    //starting score value 
    int tScore = 0;
    int streak = 0;

    //repeat
    while (restart == true)
    {
	    //starting stuff
	    Console.Clear ();
	    Console.WriteLine ("Rock, Paper, Scissors");
	    Console.WriteLine (" ");

	    //starting values
	    int rock = 1;
	    int paper = 2;
	    int Scissors = 3;


	    //program picks type
	    Random rnd = new Random ();
	    int ranNum = rnd.Next (1, 4);

	    Console.WriteLine ("Pick a choice: ");
	    string userImput = Console.ReadLine ();
	    Console.WriteLine (" ");

	    //debug mode (dowsent work ._.)
	    if (userImput == "debug")
	    {
	        debug (); 
	    }

	    //sees who wins (rock)
	    if (userImput == "rock" && ranNum == rock)
	    {
	        //resets steak to 0 on loss
	        streak = 0;


	        //dosent let streak go under 0
	        if (streak < 0)
	        {
		        streak++;
	        }

	        //tie (rock)
	        Console.WriteLine("-------| Game |-------");
	        Console.WriteLine("Status: Tie");
	        Console.WriteLine("Program Picked: Rock");
	        Console.WriteLine("-----------------------");
	        Console.WriteLine(" ");

	        Console.WriteLine("-------| Stats |-------");
	        Console.WriteLine("Total Score: " + tScore);
          Console.WriteLine("Streak: " + streak);
	        Console.WriteLine("-----------------------");
	    }
	    else if (userImput == "rock" && ranNum == paper)
	    {
	        //resets steak to 0 on loss
	        streak = 0;


	        //dosent let streak go under 0
	        if (streak < 0)
	        {
		        streak++;
	        }

	        //lose (rock)
	        Console.WriteLine("-------| Game |-------");
	        Console.WriteLine("Status: Lose");
	        Console.WriteLine("Program Picked: Paper");
	        Console.WriteLine("-----------------------");
	        Console.WriteLine (" ");

	        Console.WriteLine("-------| Stats |-------");
	        Console.WriteLine("Total Score: " + tScore);
	        Console.WriteLine("Streak: " + streak);
	        Console.WriteLine("-----------------------");
	    }
	    else if (userImput == "rock" && ranNum == Scissors)
	    {
	        //increases score  and streak by 1
	        tScore++;
	        streak++;

	        //win (rock)
	        Console.WriteLine("-------| Game |-------");
	        Console.WriteLine("Status: Win");
	        Console.WriteLine("Program Picked: Scissors");
	        Console.WriteLine("-----------------------");
	        Console.WriteLine(" ");

	        Console.WriteLine("-------| Stats |-------");
	        Console.WriteLine("Total Score: " + tScore);
	        Console.WriteLine("Streak: " + streak);
	        Console.WriteLine("-----------------------");
	    }

	    //sees who wins (paper)
	    if (userImput == "paper" && ranNum == rock)
	    {
	        //increases score  and streak by 1
	        tScore++;
	        streak++;

	        //win (paper)
	        Console.WriteLine("-------| Game |-------");
	        Console.WriteLine("Status: Win");
	        Console.WriteLine("Program Picked: Rock");
	        Console.WriteLine("-----------------------");
	        Console.WriteLine(" ");

	        Console.WriteLine("-------| Stats |-------");
      Console.WriteLine("Total Score: " + tScore);
	        Console.WriteLine("Streak: " + streak);
	        Console.WriteLine("-----------------------");
	    }
	    else if (userImput == "paper" && ranNum == paper)
	    {

	        //resets steak to 0 on loss
	        streak = 0;

	        //dosent let streak go under 0
	        if (streak < 0)
	        {
		        streak++;
	        }


	        //tie (paper)
	        Console.WriteLine("-------| Game |-------");
	        Console.WriteLine("Status: Tie");
	        Console.WriteLine("Program Picked: Paper");
	        Console.WriteLine("-----------------------");
	        Console.WriteLine(" ");

	        Console.WriteLine("-------| Stats |-------");
	        Console.WriteLine("Total Score: " + tScore);
	        Console.WriteLine("Streak: " + streak);
	        Console.WriteLine("-----------------------");
	    }
	    else if (userImput == "paper" && ranNum == Scissors)
	    {
	        //resets steak to 0 on loss
	        streak = 0;

	        //dosent let streak go under 0
	        if (streak < 0)
	        {
		        streak++;
	        }

	        //lose (paper)
	        Console.WriteLine("-------| Game |-------");
	        Console.WriteLine("Status: Lose");
	        Console.WriteLine("Program Picked: Scissors");
	        Console.WriteLine("-----------------------");
	        Console.WriteLine(" ");

	        Console.WriteLine("-------| Stats |-------");
	        Console.WriteLine("Total Score: " + tScore);
	        Console.WriteLine("Streak: " + streak);
	        Console.WriteLine("-----------------------");
	    }

	    //sees who wins (Scissors)
    	if (userImput == "scissors" && ranNum == rock)
	    {
	        //resets steak to 0 on loss
	        streak = 0;

	        //dosent let streak go under 0
	        if (streak < 0)
      {
		        streak++;
	        }

	        //lose (Scissors)
	        Console.WriteLine("-------| Game |-------");
	        Console.WriteLine("Status: Lose");
	        Console.WriteLine("Program Picked: Rock");
	        Console.WriteLine("-----------------------");
	        Console.WriteLine(" ");

	        Console.WriteLine("-------| Stats |-------");
	        Console.WriteLine("Total Score: " + tScore);
	        Console.WriteLine("Streak: " + streak);
	        Console.WriteLine("-----------------------");
	    }
	    else if (userImput == "scissors" && ranNum == paper)
	    {
	        //increases score  and streak by 1
	        tScore++;
	        streak++;

	        //win (scissors)
	        Console.WriteLine("-------| Game |-------");
	        Console.WriteLine("Status: Win");
	        Console.WriteLine("Program Picked: Paper");
	        Console.WriteLine("-----------------------");
	        Console.WriteLine(" ");

	        Console.WriteLine("-------| Stats |-------");
	        Console.WriteLine("Total Score: " + tScore);
	        Console.WriteLine("Streak: " + streak);
	        Console.WriteLine("-----------------------");
	    }
	    else if (userImput == "scissors" && ranNum == Scissors)
	    {

	        //resets steak to 0 on loss
	        streak = 0;

	        //dosent let streak go under 0
	        if (streak < 0)
	        {
		        streak++;
	        }

	        //tie (scissors)
	        Console.WriteLine("-------| Game |-------");
	        Console.WriteLine("Status: Tie");
	        Console.WriteLine("Program Picked: Scissors");
	        Console.WriteLine("-----------------------");
	        Console.WriteLine(" ");

	        Console.WriteLine("-------| Stats |-------");
	        Console.WriteLine("Total Score: " + tScore);
	        Console.WriteLine("Streak: " + streak);
	        Console.WriteLine("-----------------------");
	    }
      //restart program end
	    System.Threading.Thread.Sleep(3500);


    }
    
  }
  public static void debug ()
  {
    Console.Clear ();
    Console.WriteLine (@"\--------------{ Debug }--------------/");
    //Console.WriteLine("Program: " + ranNum);
    Console.WriteLine ("Debug: True");
    Console.WriteLine (" ");
    Console.WriteLine ("to exit type exit");

    string exit = Console.ReadLine ();

    if (exit == "exit")
    {
	    //Main();
    }
  }
}