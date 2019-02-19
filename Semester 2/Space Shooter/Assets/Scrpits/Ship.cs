using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour {

    List<GameObject> bullets = new List<GameObject>();
    float speed = 7f;
    Vector3 velocity;
    Rigidbody2D rbody;
    public GameObject BulletPrefab;

    // Use this for initialization
    void Start ()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        velocity = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity += Direction(transform.eulerAngles.z + 90);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity += Direction(transform.eulerAngles.z - 90);
        }

        rbody.velocity = velocity * (speed);

        if (Input.GetKey(KeyCode.Space))
        {
            ShootBalls();
        }
    }

    public Vector3 Direction(float eulerAnglesZ)
    {
        return new Vector3(Mathf.Cos(eulerAnglesZ * Mathf.Deg2Rad), Mathf.Sin(eulerAnglesZ * Mathf.Deg2Rad), 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            Destroy(collision.collider.gameObject);
            SceneManager.LoadScene("Game Over");
        }
    }

    void ShootBalls()
    {
        GameObject newBullet = Instantiate(BulletPrefab);
        newBullet.GetComponent<Bullet>().Initialize(transform.position + .3f * (Direction(transform.eulerAngles.z - 90).normalized),
            Direction(transform.eulerAngles.z - 90));

        bullets.Add(newBullet);
    }
}
