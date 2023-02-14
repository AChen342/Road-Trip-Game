using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Obstacle"){
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManger>().EndGame();
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
        
        }else if(collisionInfo.collider.tag == "OutOfBounds"){
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManger>().EndGame();
        
        }else if(collisionInfo.collider.tag == "Finish"){
            GetComponent<PlayerMovement>().enabled = false;
        }
    }
}

