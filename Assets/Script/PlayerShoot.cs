using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Laser LaserPrefab;
    public int maxLaserShot = 2;
    public int currentLaserShot = 0;
    public int CurrentKills = 0;
    public int MaxKills = 5;

    private bool laserActive;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootLaser();
        }

        if (CurrentKills == MaxKills)
        {
            SceneManager.LoadScene("Game Won");
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            CurrentKills++;
        }
    }

    void laserDestroyed()
    {
        currentLaserShot--;
        laserActive = false;
    }
}
