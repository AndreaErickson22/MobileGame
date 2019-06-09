using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Controllers/Clicker")]
public class Clicker : ScriptableObject
{
 public int ClickCount = 0;
       public void IncrementCount()
       {
          ClickCount++;
       }
    }

