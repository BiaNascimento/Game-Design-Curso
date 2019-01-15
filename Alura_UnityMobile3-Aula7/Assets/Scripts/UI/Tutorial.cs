using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour {

    
    public Text texto1;
 
    private IEnumerator coroutine;
  

    public int segundos;
	// Use this for initialization
	IEnumerator Start () {
        coroutine = esperar(5.0f);
        StartCoroutine(coroutine);

        texto1.text = "Olá.";
        yield return StartCoroutine(esperar(5));
        texto1.text = "Vejo que você sobreviveu.";
        yield return StartCoroutine(esperar(5));
        texto1.text = "Preciso que faça mais uma missão.";
        yield return StartCoroutine(esperar(5));
        texto1.text = "Por agora, sobreviva, em breve te direi mais.";
        yield return StartCoroutine(esperar(5));
        texto1.text = "Use o analógico para andar e aperte na tela para atirar.";
        yield return StartCoroutine(esperar(5));
        texto1.text = "Voltarei em 90 segundos para te buscar.";
        yield return StartCoroutine(esperar(5));
        texto1.text = "Câmbio e desligo.";
        yield return StartCoroutine(esperar(5));
        SceneManager.LoadScene(2);

    }

    

    

    private IEnumerator esperar(float tempoEspera) {

        yield return new WaitForSeconds(tempoEspera);
    }
}
