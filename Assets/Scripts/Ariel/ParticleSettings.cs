using UnityEngine;

[CreateAssetMenu(fileName = "ParticleSettings", menuName = "Particles/Particle Settings")]
public class ParticleSettings : ScriptableObject
{
    public Color color;
    public Sprite texture;
}
