using UnityEngine;
using System.Collections;

public class ChangeLevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeLevelMain() {
        Application.LoadLevel("Scenes");
    }

    public void ChangeLevelMenu()
    {
        Application.LoadLevel("Menu");
    }

    public void ChangeLevelEnd()
    {
        Application.LoadLevel("End");
    }

    public void ChangeLevelPresentation()
    {
        Application.LoadLevel("Presentation");
    }

    
}
