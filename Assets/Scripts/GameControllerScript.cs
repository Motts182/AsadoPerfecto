using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControllerScript : MonoBehaviour {

    public Text TiempoText;
    public Text Puntaje;
    public int puntajeValor = 0;
    public float tiempoTranscurrido = 45f;
    public ChangeLevelScript changelevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Puntaje.text = (puntajeValor).ToString();
        int minutes = Mathf.FloorToInt(tiempoTranscurrido / 60f);
        int seconds = Mathf.FloorToInt(tiempoTranscurrido - minutes * 60);

        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
        TiempoText.text = niceTime;
        tiempoTranscurrido -= Time.deltaTime;

        if (tiempoTranscurrido <= 0f)
            changelevel.ChangeLevelEnd();
	}
}
