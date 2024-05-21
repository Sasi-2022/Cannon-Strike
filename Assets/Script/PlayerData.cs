using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerData : MonoBehaviour
{


    private Player player;

    public Player PlayerInfo
    {
        get
        {
            return player;
        }
        set
        {
            player = value;
        }
    }
    /*  public void RetrievePlayerData()
      {
          try
          {
              if (player != null || GameController.instance.Player.guestLogin)
              {
                  player = new Player();
                  player = GameController.instance.PlayerDataSO.player;
                  GameController.instance.PlayerObj.player = player;
                  GameController.instance.PlayerObj.PlayerInfo = new Player();
                  GameController.SavePlayerData.Invoke();
              }

          }
          catch (Exception ex)
          {

          }

      }*/

}

    [Serializable]
    public class Player
    {
        public int CurrentLocationId;
        public int Currentid;
        public int PlayerCurrentLevel;
        public int PlayerCoinsEarned = 5000;
        public int PlayerGemsEarned = 500;
        public int Playerlives = 5;
        public bool guestLogin;
    }


