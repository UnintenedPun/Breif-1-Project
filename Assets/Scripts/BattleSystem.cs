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

        // Generate random stats for player one
        int playerOneStyle = Random.Range(1, 11);
        int playerOneLuck = Random.Range(1, 11);
        int playerOneRythm = Random.Range(1, 11);
        
        // Generate random stats for player two
        int playerTwoStyle = Random.Range(1, 11);
        int playerTwoLuck = Random.Range(1, 11);
        int playerTwoRyhtm = Random.Range(1, 11);

        // Print Stat Levels
        Debug.Log(" Player One Style is " + playerOneStyle + " Luck Is " + playerOneLuck + " Rythm Is " + playerOneRythm);
        Debug.Log(" PLayer Two Style Is " + playerTwoStyle + " Luck Is " + playerTwoLuck + " Rythm Is " + playerTwoRyhtm);
        

        // Based on each stat needs to calculate a power level
        int playerOnePowerLevel = playerOneStyle + playerOneLuck + playerOneRythm;
        int playerTwoPowerLevel = playerTwoStyle + playerTwoLuck + playerTwoRyhtm;

        // Print Power Levels
        Debug.Log(" Player One Power Is " + playerOnePowerLevel);
        Debug.Log(" Player Two Power Is " + playerTwoPowerLevel);
        
        // Calculating total power
        int totalPower = playerOnePowerLevel + playerTwoPowerLevel;

        // Print total power
        Debug.Log(" Combined Power " + totalPower);

        // Calculating chance to win for each player
        int playerOneChanceToWin = (int) (((float)playerOnePowerLevel / (int)totalPower) * 100);
        int playerTwoChanceToWin = (int) (((float)playerTwoPowerLevel / (int)totalPower) * 100);

        // Print chance to win for each player
        Debug.Log(" Player One Chance To Win " + playerOneChanceToWin);
        Debug.Log(" Player Two Chance To Win " + playerTwoChanceToWin);

        // Exp granted for battle
        int playerOneExp = 10;
        int playerTwoExp = 10;
        
        // Win - Lose - Draw senerioes
        if (playerOneChanceToWin < playerTwoChanceToWin)
        {
            Debug.Log(" Player Two WINS! ");
            int diFf = playerTwoChanceToWin - playerOneChanceToWin;
            Debug.Log(" Percent chance differance " + diFf + "%");
            playerTwoExp += diFf;
            Debug.Log(" Exp Gained is " + playerTwoExp);
        }
        else if (playerOneChanceToWin > playerTwoChanceToWin)
        {
            Debug.Log(" Player One Wins! ");
            int diFf = playerOneChanceToWin - playerTwoChanceToWin;
            Debug.Log(" Percent Chance Differnce " + diFf + "%");
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