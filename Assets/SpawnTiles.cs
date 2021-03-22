using UnityEngine;
using System.Collections;

public class SpawnTiles : MonoBehaviour
{

    private Material currentTile;
    public float speed;
    private float offset;


    // Use this for initialization
    void Start()
    {

        currentTile = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {

        offset += 0.001f;
        currentTile.SetTextureOffset("_MainTex", new Vector2(offset * speed, 0));
    }
}
