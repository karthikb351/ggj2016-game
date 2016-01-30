using UnityEngine;
using System.Collections;

public class ResumeController : MonoBehaviour {

    private int levelToLoad = 1;
	// Use this for initialization
	void Start () {
        var data = DataSave.LoadData();
        if (data == null)
        {
            Destroy(gameObject);
        }
	}

    public void loadLevel()
    {
        Application.LoadLevel(levelToLoad);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
