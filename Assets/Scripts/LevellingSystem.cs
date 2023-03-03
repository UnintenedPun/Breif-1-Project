using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining xp and detecting when we should level up!.
/// </summary>
public class LevellingSystem : MonoBehaviour
{
    private void Start()
    {
        // start with some psudeo code based on your feature spec and don't forget comments.

        // setting level to 1
        int currentLevel = 1;

        // setting experiance to 0
        int currentXp = 0;

        // threshhold to be our starting level times 100
        int currentXPThreshold = currentLevel * 100;

        // Values printed out
        Debug.Log(" Current Level: " + currentLevel);
        Debug.Log(" Current Experiance: " + currentXp);
        Debug.Log(" Current ThreshHold: " + currentXPThreshold);

        //assinging random value for exp to level up
        currentXp = Random.Range(60, 151);
        Debug.Log(" Exp Giving After Battle Is " + currentXp);

        // Check to see if our current xp is equal to our threshold
        if (currentXp >= currentXPThreshold)
        {
            currentLevel += 1;
            Debug.Log(" Level Up ");
            currentXp -= currentXPThreshold;
            currentXPThreshold= currentLevel * 100;
            Debug.Log(" Current Level: " + currentLevel);
            Debug.Log(" Current Experiance: " + currentXp);
            Debug.Log(" Current ThreshHold: " + currentXPThreshold);
        }
        else if (currentXp <= currentXPThreshold)
        {
            Debug.Log(" No Level Up ");
            Debug.Log(" Current Level: " + currentLevel);
            Debug.Log(" Current Experiance: " + currentXp);
            Debug.Log(" Current ThreshHold: " + currentXPThreshold);
        }     
    }
}
