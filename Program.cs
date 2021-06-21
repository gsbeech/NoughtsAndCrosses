namespace NoughtsAndCrosses
{
    class Program
    {
        static void Main(string[] args)
        {
            /* two humans take turns entering their choice using the same keyboard
             * players designate which square they want to play in, using the numpad as a mapping for the grid
             * game should prevent players from choosing squares that are already occupied. if they attempt an illegal move, they should be informed and given another chance to make their move
             * the game must detect when a player wins or when the board is full with no winner (a draw)
             * when the game is over the outcome needs to be displayed to the players
             * the state of the board must be displayed after each move like this:
             * 
             *      It is X's Turn
             *      O | O | X        
             *     --- --- ---
             *      X | X | O  
             *     --- --- ---
             *      X | O | O
             *      What square would you like to play in?
             *      
             *      main
             *      start a new game 
             *      
             *      noughts and crosses game
             *      runs the game
             *      asks for moves from players
             *      
             *      
             *      board
             *      
             *      
             *      player
             *      
             *      
             */

            NoughtsAndCrossesGame myGame = new NoughtsAndCrossesGame();
            myGame.RunGame();
        }
    }
}
 