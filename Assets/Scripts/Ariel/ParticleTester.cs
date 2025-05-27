using System.Collections;
using UnityEngine;

public class ParticleTester : MonoBehaviour
{
    public ParticleSpawner spawner;
    public int testAmount = 10000;
    private bool isSpawningCycle = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            StartAutoSpawnCycle();
        }
    }

    void StartAutoSpawnCycle()
    {
        if (!isSpawningCycle)
        {
            isSpawningCycle = true;
            StartCoroutine(SpawnCycle());
        }
    }

    IEnumerator SpawnCycle()
    {
        while (true)
        {
            spawner.SpawnMassiveParticles(testAmount);
            yield return new WaitForSeconds(Particle.lifeTime + 0.1f);
        }
    }
}
