using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New weapon data", menuName = "Weapon Data")]
public class WeaponData : ScriptableObject
{
    [SerializeField] private string weaponName;
    [SerializeField] private string description;
    [SerializeField] private string damage;

    public string Weaponname { get { return weaponName; } }
    public string Description { get { return description; } }
    public string Damage { get { return damage; } }

    public void PrintData()
    {
        Debug.Log(weaponName);
        Debug.Log(description);
        Debug.Log(damage);
    }


}
