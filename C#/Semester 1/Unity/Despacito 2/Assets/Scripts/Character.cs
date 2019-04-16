using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    bool canJump = true;
    float speed = 0.2f;
    float jump = 6;

    [SerializeField]
    Vector3 checkpointPos = new Vector3(-4.47f, -3.45f, 0);
    Vector3 velocity = new Vector3(0, 0, 0);
    Vector3 point = new Vector3();
    Vector3 mousePos = new Vector3();
    Rigidbody2D rbody;
    public GameObject BulletPrefab;
    public Camera cam;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        GameManager.Instance.MyCharacter = this;
    }

    // Update is called once per frame
    void Update()
    {
        velocity = rbody.velocity;

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 direction = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            ShootBullets(direction);
            AudioManager.Instance.PlayOneShot(SoundEffect.GunShot);
        }
        if (Input.GetKeyDown(KeyCode.W) && canJump == true)
        {
            velocity += Vector3.up * jump;
            canJump = false;
            AudioManager.Instance.PlayOneShot(SoundEffect.Jump);
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity += Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity += Vector3.right * speed;
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            velocity = new Vector3(velocity.x * (1 - Time.deltaTime * 5), velocity.y, 0);
        }

        rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -4f, 4f), Mathf.Clamp(velocity.y, -jump, jump), 0);
    }

    public Vector3 LookAtDirection(float MousePos)
    {
        return new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    }

    public void ShootBullets(Vector3 direction)
    {
        GameObject newBullet = Instantiate(BulletPrefab);
        newBullet.transform.position = transform.position;
        newBullet.GetComponent<Bullet>().velocity = (direction).normalized;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
            canJump = true;
        }
        if (collision.collider.tag == "death")
        {
            speed = 0.2f;
            jump = 6f;
            AudioManager.Instance.PlayOneShot(SoundEffect.Death);
            GameManager.Instance.MyCharacter.transform.position = checkpointPos;
        }
        if (collision.collider.tag == "lowJump")
        {
            jump = 4.5f;
            canJump = true;
        }
        if(collision.collider.tag == "lowSpeed")
        {
            speed = 0.05f;
            canJump = true;
        }
        if (collision.collider.tag == "backToNormal")
        {
            speed = 0.2f;
            jump = 6f;
            canJump = true;
        }
        if (collision.collider.tag == "checkpoint")
        {
            speed = 0.2f;
            jump = 6f;
            canJump = true;
            checkpointPos = transform.position;
            AudioManager.Instance.PlayOneShot(SoundEffect.Checkpoint);
        }
        if (collision.collider.tag == "infiniteJump")
        {
            canJump = true;
        }
    }

}
