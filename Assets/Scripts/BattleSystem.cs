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
        int playerOneRythm = 0;

        // Generate random stats for player one
        playerOneStyle = Random.Range(1, 11);
        playerOneLuck = Random.Range(1, 11);
        playerOneRythm = Random.Range(1, 11);
        Debug.Log("Player One Style is " + playerOneStyle + " Luck Is " + playerOneLuck + " Rythm Is " + playerOneRythm);

        //player two
        int playerTwoStyle = 0;
        int playerTwoLuck = 0;
        int playerTwoRyhtm = 0;

        // Generate random stats for player two
        playerTwoStyle = Random.Range(1, 11);
        playerTwoLuck = Random.Range(1, 11);
        playerTwoRyhtm = Random.Range(1, 11);
        Debug.Log(" PLayer Two Style Is " + playerTwoStyle + " Luck Is " + playerTwoLuck + " Rythm Is " + playerTwoRyhtm);

        // Based on each stat needs to calculate a power level
        int playerOnePowerLevel = playerOneStyle + playerOneLuck + playerOneRythm;
        int playerTwoPowerLevel = playerTwoStyle + playerTwoLuck + playerTwoRyhtm;

        // Chance too win
        
        int playerTwoChanceToWin = 0;
        int playerOneChanceToWin = 0;

        int totalPower = playerOnePowerLevel + playerTwoPowerLevel;
        playerOneChanceToWin = (int) (((float)playerOnePowerLevel / (float)totalPower) * 100);
        playerTwoChanceToWin = (int) (((float)totalPower / (float)playerTwoPowerLevel) * 100);

        int diFf = 0;
        int playerOneExp = 0;
        int playerTwoExp = 0;

        if (playerOneChanceToWin < playerTwoChanceToWin)
        {
            Debug.Log(" Player Two WINS! ");
            diFf = playerTwoChanceToWin - playerOneChanceToWin;
            Debug.Log(" Percent chance differance " + diFf);
            playerTwoExp += diFf;
            Debug.Log(" Exp Gained is " + playerTwoExp);
        }
        else if (playerOneChanceToWin > playerTwoChanceToWin)
        {
            Debug.Log(" Player One Wins! ");
            diFf = playerOneChanceToWin - playerTwoChanceToWin;
            Debug.Log(" Percent Chance Differnce " + diFf);
            playerOneExp += diFf;
            Debug.Log(" Exp Gained is " + playerOneExp);
         
        }
        else
        {
            Debug.Log(" Draw! ");
            playerOneExp += 5;
            playerTwoExp += 5;
            Debug.Log(" Player One Exp Gained " + playerOneExp);
            Debug.Log(" Player Two Exp Gained " + playerTwoExp);
        }
        
    }
}