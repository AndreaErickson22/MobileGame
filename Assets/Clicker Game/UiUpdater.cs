using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiUpdater : MonoBehaviour{


public Clicker Clicker;
TextMeshProUGUI textContainer;

void Start()
{
textContainer = GetComponent<TextMeshProUGUI>();
}


    // Update is called once per frame
    void Update()
    {
        textContainer.text = $"YOU'VE CLICKED IT {Clicker.ClickCount} NUMBER OF TIMES";
    }
}
