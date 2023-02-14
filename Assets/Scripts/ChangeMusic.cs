using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeMusic : MonoBehaviour
{
    public GameManger gameManger;


    void OnTriggerEnter (){
        int theLevel = SceneManager.GetActiveScene().buildIndex;
        
        if(theLevel == 5){  // Music for Stages 1-5
            FindObjectOfType<AudioManager>().StopPlaying("MainMenuMusic");
            FindObjectOfType<AudioManager>().StopPlaying("EasyStages");
            FindObjectOfType<AudioManager>().Play("IntermedStages");
        
        }else if(theLevel == 10){   // Music for Stages 6-10 
            FindObjectOfType<AudioManager>().StopPlaying("EasyStages");
            FindObjectOfType<AudioManager>().StopPlaying("IntermedStages");
            FindObjectOfType<AudioManager>().Play("FinalStages");
        
        }else if(theLevel == 15){   //Music for Stages 11-15
            FindObjectOfType<AudioManager>().StopPlaying("IntermedStages");
            FindObjectOfType<AudioManager>().StopPlaying("FinalStages");
            FindObjectOfType<AudioManager>().Play("MainMenuMusic");
        }
    }

    public void TurnOffMusic(){
    }
}
