using UnityEngine;
using System.Collections;

public class newObstacle : MonoBehaviour
{

    public GameObject ganteng;
    public Vector3 myPos;
    public float maxPos = 4.39f;
    public float delayTimer = 1f;
    public int score;
    float timer;
    float bulletlife = 5.0f;
    float range = 2.56f;
    public int score_count;
    float more = 0.1f;
    public int hasil;


    void Start()
    {
        score_count = 200;
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        score = Camerascroll.sc;
        timer -= Time.deltaTime;
        GameObject[] killEmAll;
        killEmAll = GameObject.FindGameObjectsWithTag("clone");
       

        if(GameObject.Find("p1_player") != null)
        {
            if(killEmAll.Length>1)
            {

                for (int i = 0; i < killEmAll.Length; i++)
                {
                    Destroy(killEmAll[i].gameObject, bulletlife);

                }
            }

            if (timer <= 0)
            {
                Vector3 carPos = new Vector3(GameObject.Find("Camera").transform.position.x, Random.Range(-4.48f, 3.45f), transform.position.z) + myPos;
                GameObject clone = (GameObject)Instantiate(ganteng, carPos, transform.rotation);
                clone.name = "Quad";

                clone.GetComponent<BoxCollider2D>().isTrigger = true;

                if (score > 2000)
                {
                    Vector3 carPos_2 = new Vector3(GameObject.Find("Camera").transform.position.x, Random.Range(-4.48f, 3.45f), transform.position.z) + myPos;
                    var distance = Vector3.Distance(carPos, carPos_2);


                    if (distance > range)
                    {
                        GameObject clone_2 = (GameObject)Instantiate(ganteng, carPos_2, transform.rotation);
                        clone_2.name = "Quad";

                        clone_2.GetComponent<BoxCollider2D>().isTrigger = true;
                    }

                }
                if (score <= 2050)
                {
                    if (score >= score_count)
                    {
                        delayTimer -= 0.1f;
                        score_count += 400;

                    }
                }
                else
                {
                    if (score >= score_count)
                    {
                        delayTimer -= 0.01f;
                        score_count += 400;
                    }
                }
                timer = delayTimer;

            }
        }
       



       
               
            



           
        }
       



}


