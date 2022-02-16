using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Vector3 direction;
    public AudioSource source;
    public AudioClip triggerSound;
    public float speed;
    public System.Action destroyed;

    private void Update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Barrier") || other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            if (this.destroyed != null)
            {
                this.destroyed.Invoke();
            }

            Destroy(this.gameObject);
        }
    }
}
