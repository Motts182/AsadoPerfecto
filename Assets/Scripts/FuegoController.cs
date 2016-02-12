using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FuegoController : MonoBehaviour {
    public float fuego1;
    public float fuego2;
    public float fuego3;

    public Button btnRef1;
    public Button btnRef2;
    public Button btnRef3;

    public Sprite sPrendido1;
    public Sprite sApagado1;
    
    public Sprite sPrendido2;
    public Sprite sApagado2;

    public Sprite sPrendido3;
    public Sprite sApagado3;

    public GameObject[] btns;
    
	void Start () {
        ModificarValorFuego1();
	}

    public void ModificarValorFuego1()
    {
        btns = GameObject.FindGameObjectsWithTag("btni");
        foreach (GameObject btn in btns)
        {
         //   btn.GetComponent<ParrillaSlotController>().tiempoDeCoccion = 0;
            btn.GetComponent<ParrillaSlotController>().fuegoTime = fuego1;

            btnRef1.GetComponent<Image>().sprite = sPrendido1;
            btnRef2.GetComponent<Image>().sprite = sApagado2;
            btnRef3.GetComponent<Image>().sprite = sApagado3;
        }
    }

    public void ModificarValorFuego2()
    {
        btns = GameObject.FindGameObjectsWithTag("btni");
        foreach (GameObject btn in btns)
        {
          //  btn.GetComponent<ParrillaSlotController>().tiempoDeCoccion = 0;
            btn.GetComponent<ParrillaSlotController>().fuegoTime = fuego2;

            btnRef1.GetComponent<Image>().sprite = sApagado1;
            btnRef2.GetComponent<Image>().sprite = sPrendido2;
            btnRef3.GetComponent<Image>().sprite = sApagado3;
        }
    }

    public void ModificarValorFuego3()
    {
        btns = GameObject.FindGameObjectsWithTag("btni");
        foreach (GameObject btn in btns)
        {
          //  btn.GetComponent<ParrillaSlotController>().tiempoDeCoccion = 0;
            btn.GetComponent<ParrillaSlotController>().fuegoTime = fuego3;

            btnRef1.GetComponent<Image>().sprite = sApagado1;
            btnRef2.GetComponent<Image>().sprite = sApagado2;
            btnRef3.GetComponent<Image>().sprite = sPrendido3;
        }
    }



}
