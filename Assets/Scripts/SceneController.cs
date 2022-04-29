using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    PAUSED,
    PLAYING
}
public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    public GameState state;

    public Transform playerStartPosition;
    public Transform playerPrefab;
    public Transform player;
    public CamaraFollowPlayer camara;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    public void Pause(bool pause)
    {
        if(pause)
        {
            state = GameState.PAUSED;
            Time.timeScale = 0;
        }
        else
        {
            state = GameState.PLAYING;
            Time.timeScale = 1;
        }
    }
    public void restartGame()
    {
        
        player.GetComponent<PlayerInputController>().destroyPlayer();
        player = Instantiate(playerPrefab, playerStartPosition.position, Quaternion.identity);
        camara.player = player;
    }

}
