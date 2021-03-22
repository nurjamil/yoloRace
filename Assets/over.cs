using UnityEngine;
using System.Collections;

public class over : MonoBehaviour {
    public GameObject gameover;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.name == "Quad")
        {
            Destroy(gameObject);
        }
        Instantiate(gameover, transform.position, transform.rotation);
    }
}
