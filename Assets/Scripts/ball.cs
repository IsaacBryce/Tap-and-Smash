using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
    private paddle paddle;
    private bool started = false;
    private Vector3 paddletoballV;
	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<paddle>();
        paddletoballV = this.transform.position - paddle.transform.position;

    }

    // Update is called once per frame
    void Update() {
        if (!started) {
            this.transform.position = paddle.transform.position + paddletoballV;

            if (Input.GetMouseButtonDown(0)) {
                print("player clicked, launching");
                started = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }
    }
    void OnCollisionEnter2D (Collision2D collision){
        Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));

        if (started) {
            GetComponent<Rigidbody2D>().velocity += tweak;
            GetComponent<AudioSource>().Play();
        }


        }
        


	
}
