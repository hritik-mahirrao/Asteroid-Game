using UnityEngine;

[CreateAssetMenu(fileName = "SpaceShipProperties",menuName = "Asteroids/Spaceship")]
public class PlayerProperties : ScriptableObject
{
    public float ThrustSpeed = 1f, RotationSpeed = 0.1f;
    public int lives = 3;
}
