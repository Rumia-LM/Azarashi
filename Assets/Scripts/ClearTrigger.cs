using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearTrigger : MonoBehaviour
{
    GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        gameController.IncreaseScore();
    }

}