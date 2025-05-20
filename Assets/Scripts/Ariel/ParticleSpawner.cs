using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public Sprite[] possibleTextures;
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
        Vector2 spawnPos = transform.position;
        Color color = new Color(Random.value, Random.value, Random.value);
        Sprite texture = possibleTextures[Random.Range(0, possibleTextures.Length)];
        Vector2 dir = Random.insideUnitCircle.normalized;
        float speed = Random.Range(1f, 3f);

        ParticleManager.Instance.SpawnParticle(spawnPos, color, texture, dir, speed);
    }
}

