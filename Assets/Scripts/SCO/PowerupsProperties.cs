using UnityEngine;
[CreateAssetMenu(fileName = "PowerupProperties",menuName = "Asteroids/Powerups")]
public class PowerupsProperties : ScriptableObject
{
    public GameObject powerupPrefab,pickupPrefab;
    public enum PowerupType { Shield,Bullet}
    public PowerupType CurtPowerup;
    public float powerUpDuration;
}
