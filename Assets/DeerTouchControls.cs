using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerTouchControls : MonoBehaviour
{
    public float Speed = 10;
    public float MinY = -3.5f;
    public float MaxY = 3.5f;

    Vector2 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        // DONT SHOOT FORWARD WHEN THE GAME FIRST STARTS
        targetPos.x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, Time.deltaTime * Speed);
        if (Input.GetMouseButton(0))
        {
            HandleMoveToPosition(Input.mousePosition);
        }

        if (Input.touches.Length > 0)
        {
            HandleMoveToPosition(Input.touches[0].position);
        }
    }

    void HandleMoveToPosition(Vector3 rawPos)
    {
        var pos = Camera.main.ScreenToWorldPoint(rawPos);
        if(pos.y > MaxY)
        {
            pos.y = MaxY;
        }
        if(pos.y < MinY)
        {
            pos.y = MinY;
        }
        targetPos.y = pos.y;
    }

}
