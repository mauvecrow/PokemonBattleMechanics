namespace PokemonBattleMechanics;

public class BattleEngine
{
    private string player1;
    private string player2;
    private bool isPlayer1Turn;
    private int rounds;
    
    public BattleEngine() { }

    public void startBattle()
    {
        bool victory = false;
        int maxRounds = 10;
        rounds = 0;
        player1 = "Bradley";
        player2 = "Lance";
        while (!victory && rounds < maxRounds)
        {
            Console.WriteLine("Starting battle between players: " + player1 + " and " + player2);
            
            // get input
            // string choice = Console.ReadLine();
            // Console.WriteLine("You chose " + choice);
            
            // do stuff
            
            // check for win conditions
            rounds+=3;
        }
    }
    
}