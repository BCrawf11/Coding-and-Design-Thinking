using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 velocity = new Vector3(0, 0, 0);
    Rigidbody2D rbody;
    float timer = 0;
    float timeToAction = 4;
    float speed = 10f;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Initialize the ball
    /// </summary>
    /// <param name="position">Position to spawn</param>
    /// <param name="velocity">Direction * speed</param>
    /// 

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeToAction)
        {
            DestroyImmediate(gameObject);
            timer = 0;
        }

        rbody.velocity = velocity * speed;
    }

    private void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(collider.gameObject);
        }
    }

    public void Initialize(Vector3 position, Vector3 velocity)
    {
        transform.position = position;
        this.velocity = velocity;
    }
}

