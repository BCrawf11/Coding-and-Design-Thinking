using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public Vector3 velocity = new Vector3(0, 0, 0);
    float speed = 7f;
    float timeLeft = 1f;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
        }

        transform.position += velocity * Time.deltaTime * speed;

        float distance = Vector3.Distance(transform.position, GameManager.Instance.MyCharacter.transform.position);

        if (distance > 7)
        {
            GameObject.DestroyImmediate(gameObject, true);
        }
    }
}
