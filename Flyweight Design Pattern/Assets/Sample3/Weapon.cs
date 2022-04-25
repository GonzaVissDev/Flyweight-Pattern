using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] WeaponData weaponData;

    private void OnMouseDown()
    {
        Debug.Log("Name:" + weaponData.Weaponname + "DMG:" + weaponData.Damage);
    }
}
