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
      public void RetrievePlayerData()
      {
          try
          {
              if (player != null || GameplayController.instance.Player.guestLogin)
              {
                  player = new Player();
                  player = GameplayController.instance.PlayerDataSO.player;
                GameplayController.instance.PlayerObj.player = player;
                GameplayController.instance.PlayerObj.PlayerInfo = new Player();
                GameplayController.SavePlayerData.Invoke();
              }

          }
          catch (Exception ex)
          {

          }

      }

}

    [Serializable]
    public class Player
    {
        
        public int PlayerCurrentLevel=1;
        
        public bool guestLogin;
    }


