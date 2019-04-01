namespace RPSCore
{
    // For a match the sequence will follow the pattern
    // GetReady(); to set parameters for the match such as how many games will be played
    // Repeated calls to the next two methods for each game
    //  MakeMove(); your turn
    //  GameResult(); result of the game included what my move was
    // End of repeated calls
    // Result(); to give final result for match
    public interface IRPSPlayer
    {
        //get ready to play numGames games and in each game you will have numDynamite dynamites
        //return any comments you want to make to your opponent
        string GetReady(int numGames, int numDynamite);

        //return the move you want to make for this game
        Move MakeMove();

        //result of the current game along with opponents move
        void GameResult(Outcome yourOutcome, Move opponentMove);

        //result of all of the games
        //return any comment you want to make about the outcome
        string Result(Outcome yourOutcome);
    }
}
