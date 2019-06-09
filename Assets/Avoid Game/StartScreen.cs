using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManager;

public class StartScreen : MonoBehaviour
{
    float timeTillStart = 10;
    
    private void Update()
    {
        if(Input.touches.Length > 0)
        {
            StartGame();
        }
    }
    // Start is called before the first frame update
    public void StartGame()
    {
      SceneManager.LoadScene(1);  
    }

    }

