using UnityEngine;
using UnityEngine.UI;

public class ShowDeaths : MonoBehaviour
{
    public Text dc;

    // Update is called once per frame
    void Update()
    {
        dc.text = FindObjectOfType<DeathCounter>().DisplayDeaths();
    }
}
