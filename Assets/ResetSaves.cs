using UnityEngine;

/// <summary>
/// This class provides functionality to reset saved game data.
/// </summary>
public class ResetSaves : MonoBehaviour
{
    /// <summary>
    /// Called when the script instance is being loaded.
    /// Disables the game object if not running in the Unity Editor.
    /// </summary>

    /// <summary>
    /// Resets all saved game data by deleting all PlayerPrefs.
    /// </summary>
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }
}