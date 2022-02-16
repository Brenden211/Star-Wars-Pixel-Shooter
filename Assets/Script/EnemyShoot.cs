using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Laser enemyLaserPrefab;
    public int maxLaserShot = 1;
    public int currentLaserShot = 0;

    private bool laserActive = false;

    private void Update()
    { 
        if (!laserActive && Random.value < 0.5)
        {
            ShootLaser();
        }
    }

    void ShootLaser()
    {

        foreach (Transform enemy in this.transform)
        {

            if (!enemy.gameObject.activeInHierarchy)
            {
                continue;
            }

            if (Random.value < 5)
            {
                Instantiate(this.enemyLaserPrefab, enemy.position, Quaternion.identity);
                break;
            }
        }
    }

    void laserDestroyed()
    {
        currentLaserShot--;
        laserActive = false;
    }
}
