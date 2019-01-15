using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWin : MonoBehaviour {

    public bool item;
    public Text contador;
    public float tempo, tempoLimite;
    public GameObject vitoria;


    // Use this for initialization
    void Start () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Jogador")
            item = true;
        Debug.Log("Deu bom");
    }
    // Update is called once per frame
    void Update () {
        tempo += Time.deltaTime;
        contador.text = tempo.ToString("F1");
        if (tempo <= tempoLimite && item == true)
        {
            Debug.Log("funfou");
            proximaFase();
        }
    }
    void proximaFase()
    {

        vitoria.SetActive(true);
        Time.timeScale = 0;


    }
}
