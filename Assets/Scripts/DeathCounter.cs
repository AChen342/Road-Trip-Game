using UnityEngine;

public class DeathCounter : MonoBehaviour
{

    public int numOfDeaths = 0;
    public static DeathCounter instance;    //References to current instance of audio manager

    void Awake()
    {  
        if(instance == null)
            instance = this;
        else{
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

    }
    
    public void increaseDeaths(){
        numOfDeaths+=1;
    }

    public string DisplayDeaths(){
        return numOfDeaths.ToString();
    }

}
