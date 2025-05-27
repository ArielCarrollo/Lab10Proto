using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public ParticleSettings[] particleSettings;
    public float spawnRate = 0.1f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            timer = 0;
            SpawnRandomParticle();
        }
    }

    void SpawnRandomParticle()
    {
        if (particleSettings.Length == 0) return;

        Vector2 spawnPos = transform.position;

        // Selecciona un Flyweight aleatorio
        ParticleSettings selectedSettings =
            particleSettings[Random.Range(0, particleSettings.Length)];

        Vector2 dir = Random.insideUnitCircle.normalized;
        float speed = Random.Range(1f, 3f);

        ParticleManager.SpawnParticle(spawnPos, dir, speed, selectedSettings);
    }
}
