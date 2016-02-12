using UnityEngine;
using System.Collections;

public class Presentation : MonoBehaviour {
    public ChangeLevelScript changeleve;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        print(Time.time);
        if(Time.time >= 2f)
            changeleve.ChangeLevelMenu();
	}
}
