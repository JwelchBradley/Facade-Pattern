/*
 * (Jacob Welch)
 * (TextDisplayer)
 * (Facade Pattern)
 * (Description: Displays text to the user.)
 */
using TMPro;
using UnityEngine;

public class TextDisplayer : MonoBehaviour
{
    #region Fields
    /// <summary>
    /// The text that is to be displayed. The text attached to this object.
    /// </summary>
    private TextMeshProUGUI textMeshProUGUI;
    #endregion

    #region Functions
    /// <summary>
    /// Initializes components.
    /// </summary>
    private void Awake()
    {
        textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();
    }

    /// <summary>
    /// Displays the text to the user.
    /// </summary>
    /// <param name="text">The text that should be displayed.</param>
    public void DisplayText(string text)
    {
        gameObject.SetActive(text != "");

        if (textMeshProUGUI == null) return;

        textMeshProUGUI.text = text;
    }
    #endregion
}
