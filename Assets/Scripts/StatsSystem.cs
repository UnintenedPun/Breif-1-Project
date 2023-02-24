using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.XR;

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
    public int luck;
    public int rhythm;

    private void Start()
    {
        // start with some psudeo code based on your feature spec and don't forget comments.

        // setting random values for the 3 different stats

        agility= UnityEngine.Random.Range(0, 11);
        intelligence= UnityEngine.Random.Range(0, 11);
        strength= UnityEngine.Random.Range(0, 11);

        // printing the stats out to debug
        Debug.Log(" My Strength is " + strength + " My Agility is " + agility + " My Intelligence is " + intelligence);

        // Each stat should have a conversion rate 
        // Style - should be based on strength at a rate of  1 : 1
        // Rhythm - should be based on agility at a rate of  1 : 0.5
        // Luck - should be based on intelligence at a rate of 1: 1.5

        style = strength;
        luck = (int) ((float)intelligence *1.5);
        rhythm = (int) ((float)agility * 0.5);

        // Print these Values Out
        Debug.Log(" My Style is " + style + " My Rhythm is " + rhythm + " My Luck is " + luck);

        
        Debug.Log(" Level Up ");

        // These stat points should be distributed evenly or upon a formula to all stats:
        
        // 10 new stat points are awarded on leveling up.
        agility += 4;
        intelligence += 2;
        strength += 4;

        style = strength;
        luck = (int)((float)intelligence * 1.5);
        rhythm = (int)((float)agility * 0.5);

        // Upon the stats being assigned,
        // we need to recalculate the dancing stats as they have increased using the conversion system outlined above.
        //Print out our new physical and dancing stat values to the console.

        Debug.Log("The New Stats are!");
        Debug.Log(" My Strength is " + strength + " My Agility is " + agility + " My Intelligence is " + intelligence);
        Debug.Log(" My Style is " + style + " My Rhythm is " + rhythm + " My Luck is " + luck);
    }
}
