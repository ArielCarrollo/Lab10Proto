using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public GameObject particlePrefab;
    private static GameObject s_particlePrefab;
    private static Transform s_transform;

    private void Awake()
    {
        s_particlePrefab = particlePrefab;
        s_transform = transform;
    }

    public static void SpawnParticle(Vector2 position, Vector2 direction,
                                   float speed, ParticleSettings settings)
    {
        GameObject newParticle = Instantiate(s_particlePrefab, position, Quaternion.identity);
        newParticle.transform.parent = s_transform;
        Particle p = newParticle.GetComponent<Particle>();
        p.Initialize(direction, speed, settings);
    }
}