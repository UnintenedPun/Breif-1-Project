using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
    private void Start()
    {
        // start with some psudeo code based on your feature spec and don't forget comments.

        //player one
        int playerOneStyle = 0;
        int playerOneLuck = 0;
        int playerOneRyhtm = 0;

        //player two
        int playerTwoStyle = 0;
        int playerTwoLuck = 0;
        int playerTwoRyhtm = 0;

        int playerOnePowerLevel = 0;
        int playerTwoPowerLevel = 0;


        int totalPower = 0;
        int playerOneChanceToWin = 0;
        int playerTwoChanceToWin = 0;

    }
}
