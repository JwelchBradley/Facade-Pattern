/*
 * (Jacob Welch)
 * (CharacterAnimator)
 * (Facade Pattern)
 * (Description: Sets trigger for a characters animators.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
    #region Fields
    /// <summary>
    /// The animator that is being used for the character.
    /// </summary>
    private Animator animator;
    #endregion

    #region Functions
    /// <summary>
    /// Initializes components.
    /// </summary>
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    /// <summary>
    /// Animates the character based on the given trigger.
    /// </summary>
    public void AnimateCharacter(string animationTrigger)
    {
        if (animator == null) return;

        animator.SetTrigger(animationTrigger);
    }
    #endregion
}
