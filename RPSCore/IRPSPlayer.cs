namespace RPSCore
{
    public interface IRPSPlayer
    {
        //get ready to play numGames games and in each game you will have numWaterbombs waterbombs
        //and numDynamite dynamites
        //return any comments you want to make to your opponent
        string GetReady(int numGames, int numWaterbombs, int numDynamite);

        //return the move you want to make for this game
        Move MakeMove();

        //result of the current game along with opponents move
        void GameResult(Outcome yourOutcome, Move opponentMove);

        //result of all of the games
        //return any comment you want to make about the outcome
        string Result(Outcome yourOutcome);
    }
}
