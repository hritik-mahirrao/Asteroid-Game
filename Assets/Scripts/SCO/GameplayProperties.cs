using UnityEngine;

[CreateAssetMenu(fileName = "GameplaySettings",menuName = "Asteroids/Gameplay")]
public class GameplayProperties : ScriptableObject
{
    public float SpwanDist = 12f, SpwanRate = 1f,PowerupSpwanDelay = 10;
    public int AmmountPerSpwan = 1;
}
