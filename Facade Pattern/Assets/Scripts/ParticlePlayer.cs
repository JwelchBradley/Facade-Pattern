/*
 * (Jacob Welch)
 * (ParticlePlayer)
 * (Facade Pattern)
 * (Description: Plays particle effects on the screen.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{
    #region Fields
    /// <summary>
    /// The particle systems that are being used.
    /// </summary>
    private ParticleSystem[] particleSystemComponent;
    #endregion

    #region Functions
    /// <summary>
    /// Initializes components.
    /// </summary>
    private void Awake()
    {
        particleSystemComponent = GetComponentsInChildren<ParticleSystem>();
    }

    /// <summary>
    /// Plays a particle effect with a given color for the particles.
    /// </summary>
    /// <param name="particleColor">The color the particles should be.</param>
    public void PlayParticleEffect(Color particleColor)
    {
        if (particleSystemComponent == null) return;

        foreach(var particleSystem in particleSystemComponent)
        {
            particleSystem.startColor = particleColor;
            particleSystem.Play();
        }
    }
    #endregion
}
