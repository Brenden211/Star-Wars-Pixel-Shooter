using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Projectile EnemyLaserPrefab;
    public System.Action destroyed;
    public bool EnemyLaserActive = false;
    public int ShootNumber = 0;
    public int MaxShootNumber = 8;

    public void Update()
    {
       if (!EnemyLaserActive && ShootNumber < MaxShootNumber)
       {
           Instantiate(this.EnemyLaserPrefab, this.transform.position, Quaternion.identity);
           EnemyLaserActive = true;
            ShootNumber++;
       }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        EnemyLaserActive = false;
        if (other.gameObject.layer == LayerMask.NameToLayer("Barrier") || other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            if (this.destroyed != null)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
