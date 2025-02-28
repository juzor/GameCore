using static GameCore.GameManager;

namespace GameCore.Tests
{
    [TestFixture]
    public class GameManagerTests
    {
        private GameManager gameManager;

        [SetUp]
        public void Setup()
        {
            gameManager = new GameManager();
            gameManager.SetGameState(GameState.Idle);
        }

        [Test]
        public void GameManager_StartsInIdleState()
        {
            Assert.That(gameManager.CurrentState, Is.EqualTo(GameState.Idle));
        }

        [Test]
        public void GameManager_TransitionsToPlaying()
        {
            gameManager.SetGameState(GameState.Playing);
            Assert.That(gameManager.CurrentState, Is.EqualTo(GameState.Playing));
        }

        [Test]
        public void GameManager_CanPauseGame()
        {
            gameManager.SetGameState(GameState.Playing);
            gameManager.SetGameState(GameState.Paused);
            Assert.That(gameManager.CurrentState, Is.EqualTo(GameState.Paused));
        }
    }
}