using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyweight : MonoBehaviour
{
    //The list that stores all aliens
    List<Alien> allAliens = new List<Alien>();

    List<string> weapons;
    List<string> names;
    List<string> powerup;


    void Start()
    {
        //List used when flyweight is enabled
        weapons = GetAlien();
        names = GetAlien();
        powerup = GetAlien();

        //Create all aliens
        for (int i = 0; i < 10000; i++)
        {
            Alien newAlien = new Alien();

            //Add list of string
            /*Without flyweight
            newAlien.weapons = GetAlien();
            newAlien.names = GetAlien();
            newAlien.powerup = GetAlien();*/
          
            //With flyweight
            newAlien.weapons = weapons;
            newAlien.names = names;
            newAlien.powerup = powerup;
        
            allAliens.Add(newAlien);
        }
    }


    //Generate a list with body part positions
    List<string> GetAlien()
    {
        //Create a new list
        List<string> aliensetup = new List<string>();

        //Add body part positions to the list
        for (int i = 0; i < 1000; i++)
        {
            aliensetup.Add(i.ToString());
        }

        return aliensetup;
    }
}

