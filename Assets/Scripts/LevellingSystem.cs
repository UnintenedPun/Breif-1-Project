using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining xp and detecting when we should level up!.
/// </summary>
public class LevellingSystem : MonoBehaviour
{
    public int currentLevel = 1; // Our current level.

    public int currentXp = 0; // The current amount of xp we have accumulated.

    public int currentXPThreshold = 0; // The amount of xp required to level up.

    private void Start()
    {
        // start with some psudeo code based on your feature spec and don't forget comments.
        // setting level to 1
        currentLevel = 1;
        // setting experiance to 0
        currentXp = 0;
        // thrershhold to be our starting level times 100
        currentXPThreshold = currentLevel * 100;
        // Values printed out
        Debug.Log(" Current Level: " + currentLevel);
        Debug.Log(" Current Experiance: " + currentXp);
        Debug.Log(" Current ThreshHold: " + currentXPThreshold);

        // Level up has occured "100" points added
        Debug.Log(" Level Up ");
        currentXp = Random.Range(0, 101);
        if (currentLevel < 1)
        {
            currentXp *= currentLevel;


        }
        if (Input.GetKeyUp.(KeyCode.Return))

    }
}
