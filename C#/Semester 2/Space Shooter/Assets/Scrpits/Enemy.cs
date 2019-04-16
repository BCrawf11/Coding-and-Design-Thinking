using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Vector3 velocity = new Vector3(0, 0, 0);
    float timer = 0;
    float timeToAction = 5;
    float speed = 7f;
    Rigidbody2D rbody;

	// Use this for initialization
	void Start ()
    {
        rbody = GetComponent<Rigidbody2D>();

	}
    /// <summary>
    /// Initialize the ball
    /// </summary>
    /// <param name="position">Position to spawn</param>
    /// <param name="velocity">Direction * speed</param>
    /// 

    void Update ()
    {
        timer += Time.deltaTime;

        if (timer >= timeToAction)
        {
            DestroyImmediate(gameObject);
            timer = 0;
        }

        rbody.velocity = velocity * speed;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Behind")
        {
            Destroy(gameObject);
            Ship.lives--;
        }
    }

    public void Initialize(Vector3 position, Vector3 velocity)
    {
        transform.position = position;
        this.velocity = velocity;
    }
}
