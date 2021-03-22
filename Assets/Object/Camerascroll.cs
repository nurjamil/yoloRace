using UnityEngine;
using System.Collections;

public class Camerascroll : MonoBehaviour
{
    public Vector3 myPos;
    public static int sc;
    public float sco;
    public int high;
    GameObject player;

    void Start()
    {

        GameObject player;
        sco = 0;
        PlayerPrefs.SetInt("high", 0);
        player = GameObject.Find("p1_player");

    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            transform.position = new Vector3(GameObject.Find("p1_player").transform.position.x,
        transform.position.y,
        transform.position.z) + myPos;
        }
        
        sco += Time.deltaTime * 10;
        sc = (int)sco;
        if (high<sco)
        {
            PlayerPrefs.SetInt("high", sc);
        }

    }

    void OnGUI()
    {
        string hi = high.ToString();
        string score = sc.ToString();
        GUIStyle myButtonStyle = new GUIStyle(GUI.skin.button);
        myButtonStyle.fontSize = 30;

        // Load and set Font
        Font myFont = (Font)Resources.Load("youmurdererbb_reg", typeof(Font));
        myButtonStyle.font = myFont;

        // Set color for selected and unselected buttons
        myButtonStyle.normal.textColor = Color.red;

        GUI.Label(new Rect(Screen.width * 0.8f, Screen.height * 0.03f, Screen.width * 0.2f, Screen.height * 0.07f), score, myButtonStyle);
        GUI.Label(new Rect(Screen.width * 0.65f, Screen.height * 0.03f, Screen.width * 0.2f, Screen.height * 0.07f), "Score  ", myButtonStyle);

    }

}