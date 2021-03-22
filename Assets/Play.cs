using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

	void Update() { 
        if(Input.GetMouseButton(0))
             Application.LoadLevel("p1_project_s1");
    }

}
