using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Laser LaserPrefab;
    public int maxLaserShot = 2;
    public int currentLaserShot = 0;

    private bool laserActive;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootLaser();
        }
    }

    void ShootLaser()
    {
        if (!laserActive || currentLaserShot < maxLaserShot)
        {
            currentLaserShot++;
            Laser projectile = Instantiate(this.LaserPrefab, this.transform.position, Quaternion.identity);
            projectile.destroyed += laserDestroyed;
            laserActive = true;
        }
    }

    void laserDestroyed()
    {
        currentLaserShot--;
        laserActive = false;
    }
}
