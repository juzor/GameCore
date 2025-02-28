
namespace GameCore.Tests
{
    [TestFixture]
    public class ScoreSystemTests
    {
        private ScoreSystem scoreSystem;

        [SetUp]
        public void Setup()
        {
            scoreSystem = new ScoreSystem();
        }

        [Test]
        public void ScoreSystem_StartsAtZero()
        {
            Assert.That(scoreSystem.Score, Is.EqualTo(0));
        }

        [Test]
        public void ScoreSystem_CanIncreaseScore()
        {
            scoreSystem.AddScore(10);
            Assert.That(scoreSystem.Score, Is.EqualTo(10));
        }

        [Test]
        public void ScoreSystem_CanResetScore()
        {
            scoreSystem.AddScore(10);
            scoreSystem.ResetScore();
            Assert.That(scoreSystem.Score, Is.EqualTo(0));
        }
    }
}
