using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Vector3 direction;
    public AudioSource source;
    public AudioClip triggerSound;
    public float speed;
    public System.Action destroyed;
    public int CurrentKills = 0;
    public int MaxKills = 5;

    private void Update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Barrier") || other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            {
                CurrentKills = 1;
                this.destroyed.Invoke();
            }

            else if (this.destroyed != null)
            {
                this.destroyed.Invoke();
            }

            Destroy(this.gameObject);
        }
    }
}
