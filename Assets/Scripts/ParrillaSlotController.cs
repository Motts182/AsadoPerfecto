using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ParrillaSlotController : MonoBehaviour {
    public bool empty;
    public Button bandeja;
    public Sprite spriteEmpty;
    public string carneNombre;
    public GameControllerScript GameControllerScript;
    public float tiempoDeCoccion = 0;
    public float fuegoTime = 0;
    public GameObject[] bsItems;
    public GameControllerScript GameControllerS;
    void Awake() {
        empty = true;
        bsItems = GameObject.FindGameObjectsWithTag("bsitem");
    }

    void Update() {
        tiempoDeCoccion -= (Time.deltaTime + fuegoTime);

        if (carneNombre == "Verdura")
        {
            if (tiempoDeCoccion < 8 && tiempoDeCoccion > 6)
            {
                GetComponent<Image>().color = Color.white;
            }
            if (tiempoDeCoccion < 6 && tiempoDeCoccion > 2)
            {
                GetComponent<Image>().color = Color.grey;
            }
            if (tiempoDeCoccion < 0)
            {
                GetComponent<Image>().color = Color.black;
            }
        }

        if (carneNombre == "carne")
        {
            if (tiempoDeCoccion < 18 && tiempoDeCoccion > 14)
            {
                GetComponent<Image>().color = Color.white;
            }
            if (tiempoDeCoccion < 5 && tiempoDeCoccion > 2)
            {
                GetComponent<Image>().color = Color.grey;
            }
            if (tiempoDeCoccion < 0)
            {
                GetComponent<Image>().color = Color.black;
            }
        }

        if (carneNombre == "Chorizo")
        {
            if (tiempoDeCoccion < 12 && tiempoDeCoccion > 9)
            {
                GetComponent<Image>().color = Color.white;
            }
            if (tiempoDeCoccion < 5 && tiempoDeCoccion > 2)
            {
                GetComponent<Image>().color = Color.grey;
            }
            if (tiempoDeCoccion < 0)
            {
                GetComponent<Image>().color = Color.black;
            }
        }

    }

    void ChangeFuegoTime(float fuegoTime1) {
        fuegoTime = fuegoTime1;
    }
    
    public void ScarCarne() {
        if (carneNombre == "Verdura") {
            if (tiempoDeCoccion <8 && tiempoDeCoccion>6)
            {
                GameControllerScript.puntajeValor += 5;            
            }
            if (tiempoDeCoccion < 6 && tiempoDeCoccion > 2)
            {
                GameControllerScript.puntajeValor += 75;
                GameControllerS.tiempoTranscurrido += 1f;
            }
        }

        if (carneNombre == "carne")
        {
            if (tiempoDeCoccion < 18 && tiempoDeCoccion > 14)
            {
                GameControllerScript.puntajeValor += 15;
            }
            if (tiempoDeCoccion < 5 && tiempoDeCoccion > 2)
            {
                GameControllerScript.puntajeValor += 250;
                GameControllerS.tiempoTranscurrido += 1f;
            }
        }

        if (carneNombre == "Chorizo")
        {
            if (tiempoDeCoccion < 12 && tiempoDeCoccion > 9)
            {
                GameControllerScript.puntajeValor += 10;
            }
            if (tiempoDeCoccion < 5 && tiempoDeCoccion > 2)
            {
                GameControllerScript.puntajeValor += 175;
                GameControllerS.tiempoTranscurrido += 1f;
            }
        }

        foreach (GameObject bsi in bsItems)
        {
            if (bsi.GetComponent<BSItemScript>().isEmpty == true && empty == false) {
           //   print(bsi.name);
                bsi.GetComponent<BSItemScript>().isEmpty = false;
                bsi.GetComponent<Image>().sprite = GetComponent<Image>().sprite;
                bsi.GetComponent<Image>().color = GetComponent<Image>().color;
                break;
            }
        } 

        empty = true;
        carneNombre = null;
        GetComponent<Image>().sprite = spriteEmpty;
    }
}
