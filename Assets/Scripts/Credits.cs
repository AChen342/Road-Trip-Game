using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    public void Quit(){
        Debug.Log("Game Exited.");
        FindObjectOfType<AudioManager>().Play("MouseButton");
        Application.Quit();
    }

    public void PlayAgain(){
        SceneManager.LoadScene("Level01");
        FindObjectOfType<AudioManager>().Play("MouseButton");
        FindObjectOfType<AudioManager>().StopPlaying("MainMenuMusic");
        FindObjectOfType<AudioManager>().StopPlaying("FinalStages");
        FindObjectOfType<AudioManager>().Play("EasyStages");
    }
}
