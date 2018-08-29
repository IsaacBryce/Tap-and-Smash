using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {
    public bool autoplay = false;
    private ball ball;
	// Use this for initialization
	void Start () {
        ball = GameObject.FindObjectOfType<ball>();

    }
	
	// Update is called once per frame
	void Update () {
        if (!autoplay)
        { movewithmouse(); }
        else {
            Autoplay();
        }

     }
    void Autoplay() {
        Vector3 paddlepos = new Vector3(0f, this.transform.position.y, 0f);
        Vector3 ballpos = ball.transform.position;
        paddlepos.x = Mathf.Clamp(ballpos.x, -7.5f, 7.5f);
        this.transform.position = paddlepos;
    }
    void movewithmouse() {

        Vector3 paddlepos = new Vector3(0.5f, this.transform.position.y, 0f);
        float mousepinblock = Input.mousePosition.x / Screen.width * 16-8;
        paddlepos.x = Mathf.Clamp(mousepinblock,-7.5f,7.5f);
        this.transform.position = paddlepos;
       // print(mousepinblock);

    }
}
