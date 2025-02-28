
namespace GameCore
{
    /// <summary>
    /// Manages the player's score.
    /// </summary>
    public class ScoreSystem
    {
        private int _score;

        /// <summary>
        /// Gets the current score.
        /// </summary>
        public int Score => _score;

        /// <summary>
        /// Adds points to the score.
        /// </summary>
        /// <param name="points">The number of points to add.</param>
        public void AddScore(int points)
        {
            _score += points;
        }

        /// <summary>
        /// Resets the score to zero.
        /// </summary>
        public void ResetScore()
        {
            _score = 0;
        }
    }
}
