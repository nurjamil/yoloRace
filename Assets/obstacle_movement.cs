using UnityEngine;
using System.Collections;

public class obstacle_movement : MonoBehaviour {
    public float acceleration = 4.5f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("p1_player") != null)
            transform.Translate(acceleration * Time.deltaTime, 0, 0);
        else
            transform.Translate(0, 0, 0);
    }
}
