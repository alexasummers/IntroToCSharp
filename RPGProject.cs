using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine( "BATTLE GAME" );
    Console.WriteLine();

    Random rand = new Random();

    string player = "Player";
    int playerHp = 100;

    string enemy = "Enemy";
    int enemyHp = 100;

    int round = 1;
    bool done = false;
    while ( !done )
    {
      Console.WriteLine();
      Console.WriteLine( "-----------------------" );
      Console.WriteLine( "ROUND " + round );
      Console.WriteLine( "-----------------------" );
      Console.WriteLine( player + " HP: " + playerHp );
      Console.WriteLine( enemy + " HP: " + enemyHp );
      Console.WriteLine( "-----------------------" );
      Console.WriteLine( "1. Attack" );
      Console.WriteLine( "2. Defend and heal" );
      Console.WriteLine();
      Console.Write( ">> " );

      // User selection:
      int playerChoice = Convert.ToInt32(Console.ReadLine());

      // Enemy selection:
      int enemyChoice = rand.Next( 1, 2 );

      Console.WriteLine();
      Console.WriteLine();

      // Player action
      if ( playerChoice == 1 )
      {
        Console.WriteLine( player + " attacks " + enemy + "!" );

        // Player attack enemy
        int damage = rand.Next( 1, 7 );

        if ( enemyChoice == 2 ) 
        {
          // Enemy is defending, reduce damage
          damage -= 1;
        }

        Console.WriteLine( enemy + " takes " + damage + " damage!" );
        enemyHp -= damage;
      }

      else if ( playerChoice == 2 ) 
      {
        Console.WriteLine( player + " heals and defends!" );
        // Player defends and heals
        playerHp += 5;
        if ( playerHp > 100 ) 
        {
          // Maximum of 100
          playerHp = 100; 
        }
      }

      // Enemy action
      if ( enemyChoice == 1 )
      {
        Console.WriteLine( enemy + " attacks " + player + "!" );

        // Enemy attack player
        int damage = rand.Next( 1, 10 );

        if ( playerChoice == 2 ) 
        {
          // Enemy is defending, reduce damage
          damage -= 1;
        }

        Console.WriteLine( player + " takes " + damage + " damage!" );
        playerHp -= damage;
      }

      else if ( enemyChoice == 2 )
      {
        Console.WriteLine( enemy + " heals and defends!" );
        // Player defends and heals
        enemyHp += 5;
        if ( enemyHp > 100 ) 
        {
          // Maximum of 100
          enemyHp = 100; 
        }
      }



      // Check for game over state
      if ( playerHp <= 0 || enemyHp <= 0 )
      {
        done = true;
      }
    }

    // Who won?
    if ( playerHp <= 0 )
    {
       Console.WriteLine();
      Console.WriteLine( player + " is dead!" );
    }
    if ( enemyHp <= 0 )
    {
       Console.WriteLine();
      Console.WriteLine( enemy + " is dead!" );
    }
  }
}
