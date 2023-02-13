using System.Collections.Generic;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    public List<PowerupsProperties> powerupsAvailable;
    public List<PowerupsProperties> ActivePowerups;

    private void Update()
    {
        //lmb to activate shooting powerup 
        if (Input.GetMouseButtonDown(1))
        {
            foreach (var v in powerupsAvailable)
            {
                if (v.CurtPowerup == PowerupsProperties.PowerupType.Bullet)
                {
                    ActivePowerups.Add(v);
                    powerupsAvailable.Remove(v);
                    StartCoroutine(RemoveActivePowerup(v.powerUpDuration, v));
                    CheckActiveList(v);
                    break;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var v in powerupsAvailable)
            {
                if (v.CurtPowerup == PowerupsProperties.PowerupType.Shield)
                {
                    ActivePowerups.Add(v);
                    powerupsAvailable.Remove(v);
                    StartCoroutine(RemoveActivePowerup(v.powerUpDuration, v));
                    CheckActiveList(v);
                    break;
                }
            }
        }
    }

    void CheckActiveList(PowerupsProperties _temp)
    {
        FindObjectOfType<Player>().ChangePowerup(_temp.powerupPrefab, _temp.CurtPowerup == PowerupsProperties.PowerupType.Shield, _temp);
    }
    IEnumerator<WaitForSeconds> RemoveActivePowerup(float _waitTime, PowerupsProperties _propToRemove)
    {
        yield return new WaitForSeconds(_waitTime);
        ActivePowerups.Remove(_propToRemove);
        if (_propToRemove.CurtPowerup == PowerupsProperties.PowerupType.Bullet)
        {
            GameObject.FindObjectOfType<Player>().RemoveActiveBullet();
        }
    }
}

