
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    [Range(0, 6)]
    public float Speed = 3;
    public ScoreKeeper ScoreKeeper;
    Vector2 target;

    private void Start()
    {
        target = new Vector2(-20, transform.position.y);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * Speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            ScoreKeeper.IncrementScore();
            Destroy(gameObject);
        }
    }
}
