using UnityEngine;
using System.Collections;

public class brick : MonoBehaviour {

    public GameObject smoke;
    public AudioClip crack;
    public static int breakablecount = 0;
    private int timesHit;
    private levelmanager levelmanager;
    public Sprite[] hitsprites;
    private bool isBreakable;
    // Use this for initialization
    void Start () {
        isBreakable = (this.tag == "Breakable");
        if (isBreakable) {
            breakablecount++;
        } 
        timesHit = 0;
        levelmanager = GameObject.FindObjectOfType<levelmanager>();
    }
		
	// Update is called once per frame
	void Update () {
	    
	}

    private void OnCollisionExit2D(Collision2D collision)
    {
        
        if (isBreakable) {  handlhits();}
    }
    void handlhits() {
        AudioSource.PlayClipAtPoint(crack, transform.position);
        timesHit ++;
        int maxHits = hitsprites.Length + 1;

        //simulatewin();
        if (timesHit >= maxHits)
        {
            breakablecount--;

            Instantiate(smoke, gameObject.transform.position, Quaternion.identity);
            //Debug.Log("SMOKESHOW");
            levelmanager.brickdestroyed();
            Destroy(gameObject);
        }
        else {
            LoadSprites();
        }

    }


    void LoadSprites() {
        int spriteIndex = timesHit - 1;
        if (hitsprites[spriteIndex] != null)
        {

            this.GetComponent<SpriteRenderer>().sprite = hitsprites[spriteIndex];
        }
        else {
            Debug.LogError("sprite missing");
        }
    }
    void simulatewin() {

         levelmanager.LoadNextLevel();

    }
}
