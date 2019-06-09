using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidEnemy : MonoBehaviour
{
    [Range(0, 6)]
    public float Speed;

    [Range(0, 15)]
    public float SpinSpeed;

    Vector2 target;


    // Start is called before the first frame update
    void Start()
    {
        target = new Vector2(-20, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * SpinSpeed * 10);
        transform.position = Vector2.MoveTowards(
            transform.position, 
            target, 
            Time.deltaTime * Speed
        );

        if (transform.position.x <= -20f) {
            Destroy(gameObject);
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }


}
