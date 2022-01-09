using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public Player movement;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy"){
            movement.enabled = false;
            Endgame();
        }

    }

    void Endgame()
    {
        Invoke("Restart" , 1f);
    }

    void Restart(){
        SceneManager.LoadScene("Menu");
    }
}