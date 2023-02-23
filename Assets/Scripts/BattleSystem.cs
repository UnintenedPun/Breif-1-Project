using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

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

        // Generate random stats for player one
            playerOneStyle = Random.Range(0, 11);
            playerOneLuck = Random.Range(0, 11);
            playerOneRyhtm = Random.Range(0, 11);
       
        //player two
        int playerTwoStyle = 0;
        int playerTwoLuck = 0;
        int playerTwoRyhtm = 0;

        // Generate random stats for player two
            playerTwoStyle = Random.Range(0, 11);
            playerTwoLuck = Random.Range(0, 11);
            playerTwoRyhtm = Random.Range(0, 11);

        // Power Levels
        int playerOnePowerLevel = 0;
        int playerTwoPowerLevel = 0;

        // Based on each stat needs to calculate a power level
        playerOnePowerLevel = playerOneStyle + playerOneLuck + playerOneRyhtm;
        playerTwoPowerLevel = playerTwoStyle + playerTwoLuck + playerTwoRyhtm;

        // To do this we’ll need to calculate the overall power
        // divide our characters power levels against this
        // multiply it by 100.
        // Chance too win
        int totalPower = 0;
        totalPower = (playerOnePowerLevel + playerTwoPowerLevel);
        int playerOneChanceToWin = 0;
        playerOneChanceToWin = (totalPower / playerOnePowerLevel) * 100;
        int playerTwoChanceToWin = 0;
        playerTwoChanceToWin = (totalPower / playerTwoPowerLevel) * 100;
        int playerOneExp = 0;
        int playerTwoExp = 0;
        if (playerOneChanceToWin == playerTwoChanceToWin)
        {
            Debug.Log(" Draw ");
            playerOneExp += 1;
            playerTwoExp += 1;
        }
        else
        {
            if (playerOneExp < playerTwoExp)
            {
                Debug.Log(" PLayer Two WINS! ");
                playerTwoExp += 10;
            }
        
        else if (playerOneExp > playerTwoExp) 
            {
            Debug.Log(" PLayer One WINS! ");
            playerOneExp += 10;
            }
        }
    }
