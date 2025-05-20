using UnityEngine;
using System.Collections.Generic;

public class ParticleManager : MonoBehaviour
{
    public static ParticleManager Instance;
    public GameObject particlePrefab;

    private void Awake()
    {
        Instance = this;
    }

    public void SpawnParticle(Vector2 position, Color color, Sprite texture, Vector2 direction, float speed)
    {
        GameObject newParticle = Instantiate(particlePrefab, position, Quaternion.identity);
        newParticle.transform.parent = this.transform;
        Particle p = newParticle.GetComponent<Particle>();
        p.Initialize(color, texture, direction, speed);
    }
}
