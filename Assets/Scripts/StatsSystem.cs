using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    /// Our physical stats that determine our dancing stats.
    public int agility;
    public int intelligence;
    public int strength;

    // Our variables used to determine our fighting power.
    public int style;
    public float luck;
    public float rhythm;

    private void Start()
    {
        // start with some psudeo code based on your feature spec and don't forget comments.
        // setting random values for the 3 different stats
        agility= Random.Range(0, 10) +1;
        intelligence= Random.Range(0, 10) +1;
        strength= Random.Range(0, 10) + 1;
        // printing the stats out to debug
        Debug.Log(" My Strength is " + strength + " My Agility is " + agility + " My Intelligence is " + intelligence);
        // Calling formula for dance stats
        DanceStats();
        // print these values to debug
        Debug.Log(" My Style is " + style + " Rhythm is " + rhythm + " Luck is " + luck);
        // level up equired
        int additionalPoints = 10;
        Debug.Log(" This is additional Points " + additionalPoints);
        // stat points to be disurbuted from strength first
        Debug.Log(" YOU LEVELED UP!");
        // formula for 10 stat points
        strength += additionalPoints - 6;
        agility += additionalPoints - 6;
        intelligence += additionalPoints - 8;
        Debug.Log(" My Strength is " + strength + " My Agility is " + agility + " My Intelligence is " + intelligence);
        // Calling formula for dance stats
        DanceStats();
        Debug.Log(" My Style is " + style + " Rhythm is " + rhythm + " Luck is " + luck);

    }
    // Formula to calculate dance stats
    public void DanceStats()
    {
        // style to have a 1 : 1 with strength
        style = strength;
        // rhythm to have a 1 : 0.5 with agility
        rhythm = agility * 0.5f;
        // luck to have a 1 : 1.5 with Intelligence
        luck = intelligence * 1.5f;
        
    }
}
