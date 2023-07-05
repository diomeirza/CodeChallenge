class GameOfStone
{
    /*
        Two players called  and  are playing a game with a starting number of stones. 
        Player 1 always plays first, and the two players move in alternating turns. The game's rules are as follows:
        In a single move, a player can remove either 2, 3, or 5 stones from the game board.
        If a player is unable to make a move, that player loses the game.
        Given the starting number of stones, find and print the name of the winner. 
        P1 is named First and P2 is named Second. 
        Each player plays optimally, meaning they will not make a move that causes them to lose the game 
        if a winning move exists
        For example, if n = 4, P1 can make the following moves:
        removes 2 stones leaving 2. P2 will then remove 2 stones and win.
        removes 3 stones leaving 1. P2 cannot move and loses.
        P1 would make the second play and win the game.
    */
    public static string gameOfStones(int n)
    {
        if( n % 7 == 0 ||
            n % 7 == 1 )
            return "Second";
        return "First";
    }
    public static void Run()
    {
        int n = 8;
        string winner = gameOfStones(n);
        Console.WriteLine($"The winner of game of stone {n} is player {winner}");
    }
}