using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {


	public void startLevel() {
		Application.LoadLevel(1);
        PlayerData data = new PlayerData(){
            currentLevel = 1
        };
        DataSave.SaveData(data);
	}
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
