/*
 * (Jacob Welch)
 * (GameStateManager)
 * (Facade Pattern)
 * (Description: Calls functions for changing the game state.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    #region Fields
    [Tooltip("The component that animates the character")]
    [SerializeField] private CharacterAnimator characterAnimator;

    [Tooltip("The component that handles playing particle effects")]
    [SerializeField] private ParticlePlayer particlePlayer;

    [Tooltip("The component displaying the text")]
    [SerializeField] private TextDisplayer textDisplayer;
    #endregion

    #region Functions
    /// <summary>
    /// Takes in user input.
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            WinGame();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            LoseGame();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            DrawGame();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();
        }
    }

    /// <summary>
    /// Sets the state of the game to be "Win" and calls it's events.
    /// </summary>
    private void WinGame()
    {
        textDisplayer.DisplayText("You WIN!!!");
        particlePlayer.PlayParticleEffect(Color.green);
        characterAnimator.AnimateCharacter("Win");
    }

    /// <summary>
    /// Sets the state of the game to be "Loss" and calls it's events.
    /// </summary>
    private void LoseGame()
    {
        textDisplayer.DisplayText("You LOSE!!!");
        particlePlayer.PlayParticleEffect(Color.red);
        characterAnimator.AnimateCharacter("Lose");
    }

    /// <summary>
    /// Sets the state of the game to be "Draw" and calls it's events.
    /// </summary>
    private void DrawGame()
    {
        textDisplayer.DisplayText("DRAW!!!");
        particlePlayer.PlayParticleEffect(Color.white);
        characterAnimator.AnimateCharacter("Draw");
    }

    /// <summary>
    /// Resets the game and calls it's events.
    /// </summary>
    private void ResetGame()
    {
        characterAnimator.AnimateCharacter("Reset");
        textDisplayer.DisplayText("");
    }
    #endregion
}
