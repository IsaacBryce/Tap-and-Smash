using UnityEngine;
using System.Collections;

public class levelmanager : MonoBehaviour {
    public void LoadLevel(string name) {
        Debug.Log("level load requested for :"+ name);
        brick.breakablecount = 0;
        Application.LoadLevel(name);
    }
    public void quit(){
        Debug.Log("player pressed quit");
        Application.Quit();
    }
    public void LoadNextLevel() {
        Application.LoadLevel(Application.loadedLevel + 1);
        brick.breakablecount = 0;
    }
    public void brickdestroyed() {
        if (brick.breakablecount <= 0) {
            LoadNextLevel();
        }
    }

}
