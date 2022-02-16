using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform Enemy;
    public AnimationCurve speed;
    public System.Action killed;
    public AudioSource source;
    public AudioClip triggerSound;

    private Vector3 _direction = Vector2.right;

    private void Update()
    {
        this.transform.position += _direction * 4.0f * Time.deltaTime;

        Vector3 leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        Vector3 rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);

        foreach (Transform Enemy in this.transform)
        {

            if (_direction == Vector3.right && Enemy.position.x >= (rightEdge.x - 1.5f))
            {
                AdvanceRow();

            }
            else if (_direction == Vector3.left && transform.position.x <= (leftEdge.x + 1.5f))
            {
                AdvanceRow();
            }
        }
    }

    private void AdvanceRow()
    {
        _direction.x *= -1.0f;

        Vector3 position = this.transform.position;
        position.y -= 2.25f;
        this.transform.position = position;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Barrier") || other.gameObject.layer == LayerMask.NameToLayer("Laser"))
        {
            source.PlayOneShot(triggerSound);
            Destroy(this.gameObject);
        }
    }
}
