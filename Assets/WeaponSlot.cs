using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlot : MonoBehaviour
{

    public List<Transform> Slots;
    public GameObject Projectile;

    public void Fire()
    {
        Slots.ForEach(slot =>
       {
           Instantiate(Projectile,
               slot.transform.position,
               slot.transform.rotation
            );
       });
    }

}
