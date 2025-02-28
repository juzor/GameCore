using System;
using UnityEngine;

namespace GameCore
{
    public interface ISpawnable
    {
        GameObject Spawn(Vector3 position);
    }

    /// <summary>
    /// Handles object spawning (NPCs and collectibles) in random or fixed positions.
    /// </summary>
    public class Spawner
    {
        private GameObject _objectToSpawn;
        private Vector3 _spawnAreaMin;
        private Vector3 _spawnAreaMax;

        private ISpawnable spawnablePrefab;
        /// <summary>
        /// Default constructor for testing purposes, see SpawnerTests.cs
        /// </summary>
        public Spawner(ISpawnable spawnable)
        {
            this.spawnablePrefab = spawnable ?? throw new Exception("Spawner is not initialized with a valid prefab!");
        }
        /// <summary>
        /// Constructor for Spawner that allows spawning within a random area.
        /// </summary>
        /// <param name="objectToSpawn">The GameObject prefab to spawn.</param>
        /// <param name="spawnAreaMin">The minimum boundary of the spawn area.</param>
        /// <param name="spawnAreaMax">The maximum boundary of the spawn area.</param>
        public Spawner(GameObject objectToSpawn, Vector3 spawnAreaMin, Vector3 spawnAreaMax)
        {
            _objectToSpawn = objectToSpawn;
            _spawnAreaMin = spawnAreaMin;
            _spawnAreaMax = spawnAreaMax;
        }

        /// <summary>
        /// Spawns an object at a random position within the defined area.
        /// </summary>
        /// <returns>The spawned GameObject.</returns>
        public GameObject SpawnObject()
        {
            if (_objectToSpawn == null)
            {
                throw new Exception("Spawner is not initialized with a valid prefab!");
            }

            // Generate a random position within the area
            Vector3 randomPosition = new Vector3(
                UnityEngine.Random.Range(_spawnAreaMin.x, _spawnAreaMax.x),
                UnityEngine.Random.Range(_spawnAreaMin.y, _spawnAreaMax.y),
                UnityEngine.Random.Range(_spawnAreaMin.z, _spawnAreaMax.z)
            );

            // Spawn the object at the random position
            return UnityEngine.Object.Instantiate(_objectToSpawn, randomPosition, Quaternion.identity);
        }
        /// <summary>
        /// For testing purpose only do not use this method. See SpawnerTests.cs
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public GameObject InvalidSpawnObject()
        {
            if (spawnablePrefab == null)
                throw new Exception("Spawner is not initialized with a valid prefab!");

            return spawnablePrefab.Spawn(Vector3.zero);
        }
    }
}
