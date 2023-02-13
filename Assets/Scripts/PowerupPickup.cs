using UnityEngine;

public class PowerupPickup : MonoBehaviour
{
    public PowerupsProperties _temp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            FindObjectOfType<PowerupManager>().powerupsAvailable.Add(_temp);
            print("col");
        }
    }
}
    