
namespace GameCore
{
    /// <summary>
    /// Manages the game's state (Start, Pause, Game Over).
    /// </summary>
    public class GameManager
    {
        /// <summary>
        /// Defines the possible game states.
        /// </summary>
        public enum GameState
        {
            MainMenu,
            Playing, 
            Paused, 
            GameOver
        }

        private GameState _currentGameState;

        /// <summary>
        /// Gets the current game state.
        /// </summary>
        public GameState CurrentState => _currentGameState;

        /// <summary>
        /// Changes the game state.
        /// </summary>
        /// <param name="newState">The new game state to set.</param>
        public void SetGameState(GameState newState)
        {
            _currentGameState = newState;
        }
    }
}

