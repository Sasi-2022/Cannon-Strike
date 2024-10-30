using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    public void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll(); // Clears all PlayerPrefs data
        PlayerPrefs.Save(); // Make sure to save changes
        Debug.Log("PlayerPrefs cleared.");
    }
}

