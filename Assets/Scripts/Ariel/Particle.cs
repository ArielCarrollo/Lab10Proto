using UnityEngine;

public class Particle : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    public static float lifeTime = 2f;
    private float currentLife;
    private SpriteRenderer spriteRenderer;

    private ParticleSettings settings;

    public void Initialize(Vector2 dir, float spd, ParticleSettings settings)
    {
        this.settings = settings;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = settings.color;
        spriteRenderer.sprite = settings.texture;

        direction = dir.normalized;
        speed = spd;
        currentLife = lifeTime;
    }

    void Update()
    {
        transform.position += (Vector3)(direction * speed * Time.deltaTime);
        currentLife -= Time.deltaTime;
        if (currentLife <= 0)
        {
            Destroy(gameObject);
        }
    }
}
