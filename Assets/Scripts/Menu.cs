using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject showHowToPlay;

    public void startGame(){
        FindObjectOfType<AudioManager>().StopPlaying("MainMenuMusic");
        FindObjectOfType<AudioManager>().Play("EasyStages");
        FindObjectOfType<AudioManager>().Play("MouseButton");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OpenHowToPlay(){
        showHowToPlay.SetActive(true);
        FindObjectOfType<AudioManager>().Play("MouseButton");
    }

    public void CloseHowToPlay(){
        showHowToPlay.SetActive(false);
        FindObjectOfType<AudioManager>().Play("MouseButton");
    }
}
