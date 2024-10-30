using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GuestLoginManager : MonoBehaviour
{

    private string dataFilePath;
    private string playerName;
    private string userid;
    public Button btn;
    public void Start()
    {
        btn.onClick.AddListener(GuestLogin);
        dataFilePath = Path.Combine(Application.persistentDataPath, "userData.json");
        LoadUserData();
    }

    public void GuestLogin()
    {
        // guestName = nameInputField.text.Trim();

        if (string.IsNullOrEmpty(playerName))
        {
            playerName = "Guest_" + UnityEngine.Random.Range(1, 9).ToString(); // Generate a random guest name
            
            userid = UnityEngine.Random.Range(1000, 9999).ToString();
            
        }

        // Save guest name to GameManager
        UserData.Instance.UserName = playerName;
        UserData.Instance.UserId = userid;
        
        // Save user data locally
        SaveUserData(userid, playerName);

        

        SceneManager.LoadScene(1);
        

    }

    private void SaveUserData(string userId, string name)
    {
        PlayerDataSave playerData = new PlayerDataSave
        {
            UserId = userId,
            UserName = name,
            

        };

        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText(dataFilePath, json);
        Debug.Log("User data saved: " + json);
    }

    private void LoadUserData()
    {
        if (File.Exists(dataFilePath))
        {
            string json = File.ReadAllText(dataFilePath);
            PlayerDataSave playerData = JsonUtility.FromJson<PlayerDataSave>(json);
            UserData.Instance.UserId = playerData.UserId;
            UserData.Instance.UserName = playerData.UserName;
            // nameInputField.text = userData.Name; // Pre-fill the input field
            Debug.Log("User data loaded: " + json);
        }
    }

}
