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
		foreach (var sr in GetComponentsInChildren<SpriteRenderer>()) {
			if(sr.tag == "HiddenSprite")
				sr.enabled = !invisible;
			if (sr.tag == "VisibleSprite")
				sr.enabled = invisible;
		}	
	}
	
	// Update is called once per frame
	void Update () {
        int worldState = GameObject.FindObjectOfType<GlobalScript>().currentWorldState;
        if(worldState==state)
        {
			foreach (var sr in GetComponentsInChildren<SpriteRenderer>()) {				
				if(sr.tag == "HiddenSprite")
					sr.enabled = false;
				if(sr.tag == "VisibleSprite")
					sr.enabled = true;
			}	
            GetComponentInChildren<Collider2D>().enabled = true;
        }
        else
        {
			foreach (var sr in GetComponentsInChildren<SpriteRenderer>()) {
				if(sr.tag == "HiddenSprite")
					sr.enabled = true;
				if(sr.tag == "VisibleSprite")
					sr.enabled = false;
			}	
            GetComponentInChildren<Collider2D>().enabled = false;
        }
	}

   
}
