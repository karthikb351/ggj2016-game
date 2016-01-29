using UnityEngine;
using System.Collections;

public class GlobalScript : MonoBehaviour {

    public int currentWorldState = 0;
	public int denyWorldStateShift = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            currentWorldState = (currentWorldState == 0) ? 1 : 0;
        }
	}
}
