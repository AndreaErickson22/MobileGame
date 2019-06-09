
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandler : MonoBehaviour
{
    public Clicker Clicker;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
if (Input.touches.Length > 0)
{
    Clicker.IncrementCount();
}

    }
}
