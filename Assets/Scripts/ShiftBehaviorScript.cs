using UnityEngine;
using System.Collections;

public class ShiftBehaviorScript : MonoBehaviour {

    public int state = 0;
    public bool invisible = false;
	// Use this for initialization
	void Start () {
	    if(state == 0)
        {
            invisible = false;
        }
        else if(state == 1)
        {
            invisible = true;
        }
        GetComponentInChildren<SpriteRenderer>().enabled = invisible;
	}
	
	// Update is called once per frame
	void Update () {
        int worldState = GameObject.FindObjectOfType<GlobalScript>().currentWorldState;
        if(worldState==state)
        {
            GetComponentInChildren<SpriteRenderer>().enabled = true;
            GetComponentInChildren<Collider2D>().enabled = true;
        }
        else
        {
            GetComponentInChildren<SpriteRenderer>().enabled = false;
            GetComponentInChildren<Collider2D>().enabled = false;
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Collision");
    }
}
