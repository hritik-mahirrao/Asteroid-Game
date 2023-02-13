using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpwaner : MonoBehaviour
{
    public PowerupsProperties[] propToSpwan;
    public GameplayProperties _prop;
    public Vector2 minSpwanPos, maxSpwanPos;

    private void Start()
    {
        StartCoroutine(AddPowerUp(_prop.PowerupSpwanDelay));
    }

    IEnumerator AddPowerUp(float _time)
    {
        yield return new WaitForSeconds(_time);
        print("yes");
        SpwanPowerUp();
        StartCoroutine(AddPowerUp(_time));
    }

    void SpwanPowerUp()
    {
        var _temp = GetComponent<PowerupManager>();
        int PowerupToSpwan = Random.Range(0,propToSpwan.Length);
        if(_temp.powerupsAvailable.Contains(propToSpwan[PowerupToSpwan]))
        {
            return;
        }
        Vector2 _tempPos = minSpwanPos;
        _tempPos.x = Random.Range(minSpwanPos.x,maxSpwanPos.x);
        _tempPos.y = Random.Range(minSpwanPos.y,maxSpwanPos.y);
       Destroy(Instantiate(propToSpwan[PowerupToSpwan].pickupPrefab, _tempPos, Quaternion.identity),_prop.PowerupSpwanDelay-0.2f);
    }
}
