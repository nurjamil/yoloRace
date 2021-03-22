using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

    public float speed = 0;
	// Update is called once per frame
	void Update () {
        if(GameObject.Find("p1_player") != null)
	    GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Time.time * speed, 0f);
	}
}
