using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    public List<Vector3> teleportLocations = new List<Vector3>();
    public static int lives = 3;
    float speed = 7;
    float timer = 0;
    float timeToAction = 2;
    Vector3 velocity;
    Rigidbody2D rbody;
    public GameObject BulletPrefab;
    public GameObject EnemyPrefab;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBalls();
        }

        timer += Time.deltaTime;

        if (timer >= timeToAction)
        {
            SpawnEnemy();

            if (timeToAction > 1f)
            {
                timeToAction -= 0.05f;
            }

            timer = 0;
        }

        if (lives == 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    public Vector3 Direction(float eulerAnglesZ)
    {
        return new Vector3(Mathf.Cos(eulerAnglesZ * Mathf.Deg2Rad), Mathf.Sin(eulerAnglesZ * Mathf.Deg2Rad), 0);
    }

    private void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.tag == "Enemy")
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    void ShootBalls()
    {
        GameObject newBullet = Instantiate(BulletPrefab);
        newBullet.GetComponent<Bullet>().Initialize(transform.position, Vector3.right);
    }

    void SpawnEnemy()
    {
        GameObject newEnemy = Instantiate(EnemyPrefab);
        newEnemy.GetComponent<Enemy>().Initialize(teleportLocations[Random.Range(0, teleportLocations.Count)], Vector3.left);
    }
}
