using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    bool gameHasEnded = false;  //Controls whether the game is still going or not
    
    public float restartDelay = 1f; //Wait for a few seconds before restarting level

    public GameObject completeLevelUI;  //References to the Level Complete screen

    public DeathCounter dc;

    public void CompleteLevel(){    //Shows the Level Complete Screen
        completeLevelUI.SetActive(true);
    }

    public void EndGame(){
        //  Restarts game when player loses
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("GAME OVER!");
            dc.increaseDeaths();
            Debug.Log(dc.DisplayDeaths());
            Invoke("Restart", restartDelay);
        }

    }

    void Restart(){
        // Reloads the scene, restarts level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Awake(){
        dc = GameObject.FindObjectOfType<DeathCounter>();
    }

}
