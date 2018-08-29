using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null;
    // Use this for initialization
    void Awake()
    {
        Debug.Log("Musicplayerawake" + GetInstanceID());
        if (instance != null)
        {
            Destroy(gameObject);
            print("clone murdered");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    } 

    void Start() {
        Debug.Log("Musicplayerstart" + GetInstanceID());
       
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
