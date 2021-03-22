using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {
    public float speed = 20.0f;
    public float acceleration = 4.5f;
    Animator anim;
   
    void Start () {
        anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(acceleration, 0);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.Play("moveUp");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
            anim.SetBool("move", false);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.Play("moveDown");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed*-1);
            anim.SetBool("move", false);
        }
        else 
        {
            anim.SetBool("move",true);

            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            
        }
        
           



    }
}
