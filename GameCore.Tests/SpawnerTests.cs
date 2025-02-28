using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

namespace GameCore.Tests
{
    /// <summary>
    /// Use this Mock for Unit Testing Since NUnit does not support GameObject.Instantiate(), 
    /// using a mock object to simulate it
    /// </summary>
    public class MockSpawnable : ISpawnable
    {
        public GameObject Spawn(Vector3 position)
        {
            return new GameObject("MockObject");
        }
    }

    [TestFixture]
    public class SpawnerTests
    {
        private Spawner spawner;

        [SetUp]
        public void Setup()
        {
            spawner = new Spawner(null, new Vector3(-5, 0, -5), new Vector3(5, 0, 5));
        }

        [Test]
        public void Spawner_InvalidSpawn()
        {
            var ex = Assert.Throws<Exception>(() => new Spawner(null));
            Assert.That(ex.Message, Is.EqualTo("Spawner is not initialized with a valid prefab!"));
        }

        //[UnityTest]
        //public IEnumerator Spawner_InvalidSpawnObject()
        //{

        //    Assert.Throws<Exception>(() => spawner.SpawnObject());
        //    yield return null;
        //}
    }
}
