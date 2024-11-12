using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserDetail : MonoBehaviour
{
    //public UserDetails instance;

    public RawImage gProfilepic;
    public RawImage fProfilepic;
    public Image guestProfilepic;

    private string guestName = "Guest";
    public string Name;
    public Texture UserProfile;
    public Texture UserProfile2;

    public TextMeshProUGUI userName;

    public Button logoutBtn;

    /*private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            instance = null;
            Destroy(gameObject);
        }
    }*/
    private void OnEnable()
    {
        logoutBtn.onClick.AddListener(LogOutButtonClk);
    }

    private void Start()
    {
        if (GoogleLogin.instance.googleLoginbool == true)
        {
            GSignIn();
        }
        else if (FaceBookLogin.instance.FBLoginbool == true)
        {
            FBSignIn();
        }
        else if(GuestLoginManager.instance.guestLoginbool==true)
        {
            GuestIN();
        }
    }

    void GSignIn()
    {
        gProfilepic.gameObject.SetActive(true);
        fProfilepic.gameObject.SetActive(false);
        guestProfilepic.gameObject.SetActive(false);
        Name = GoogleLogin.instance.username;
        userName.text = Name;
        UserProfile = GoogleLogin.instance._profilePic.texture;
        Debug.LogError("userImage2");
        gProfilepic.texture = UserProfile;
    }

    void FBSignIn()
    {
        fProfilepic.gameObject.SetActive(true);
        gProfilepic.gameObject.SetActive(false);
        guestProfilepic.gameObject.SetActive(false);
        Name = FaceBookLogin.instance.Name;
        userName.text = Name;
        UserProfile2 = FaceBookLogin.instance.fbProfilepicTexture;
        fProfilepic.texture = UserProfile2;
    }

    void GuestIN()
    {
        guestProfilepic.gameObject.SetActive(true);
        fProfilepic.gameObject.SetActive(false);
        gProfilepic.gameObject.SetActive(false);
        Name = GuestLoginManager.instance.guestname;
        userName.text = "Guest " + Name;
    }

    public void LogOutButtonClk()
    {
        if (GoogleLogin.instance.googleLoginbool == true)
        {
            GoogleLogin.instance.OnSignOut();
        }
        else if (FaceBookLogin.instance.FBLoginbool == true)
        {
            FaceBookLogin.instance.Facebook_LogOut();
        }
        else
        {
            GuestLoginManager.instance.OnLogoutButtonClick();
        }
    }

}
