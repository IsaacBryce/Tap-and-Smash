using UnityEngine;
using System.Collections;

public class losecollider : MonoBehaviour {
    private levelmanager levelmanager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        levelmanager = GameObject.FindObjectOfType<levelmanager>();
        print("triggered");
        levelmanager.LoadLevel("Lose");
        print("triggered Lose screen attempt");
    }
}
