using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining xp and detecting when we should level up!.
/// </summary>
public class LevellingSystem : MonoBehaviour
{
    public int currentLevel; // Our current level.

    public int currentXp; // The current amount of xp we have accumulated.

    public int currentXPThreshold = 10; // The amount of xp required to level up.

    private void Start()
    {
        // start with some psudeo code based on your feature spec and don't forget comments.
        // setting level to 1
        currentLevel = 1;
        // setting experiance to 0
        currentXp = 0;
        // thrershhold to be our starting level times 100
        currentXPThreshold *= currentLevel;
        // Values printed out
        Debug.Log(" Current Level: " + currentLevel + " Current Experiance: " + currentXp + " Current ThreshHold Needed: " + currentXPThreshold);


    }
}
