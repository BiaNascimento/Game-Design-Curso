using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Missao2 : MonoBehaviour {


    public Text texto1;

    private IEnumerator coroutine;


    public int segundos;
    // Use this for initialization
    IEnumerator Start()
    {
        coroutine = esperar(5.0f);
        StartCoroutine(coroutine);

        texto1.text = "Então você continua viva.";
        yield return StartCoroutine(esperar(5));
        texto1.text = "Parabéns.";
        yield return StartCoroutine(esperar(5));
        texto1.text = "Antes de continuarmos, pegue munição.";
        yield return StartCoroutine(esperar(5));
        texto1.text = "Você irá precisar.";
        yield return StartCoroutine(esperar(5));
        texto1.text = "Há mais sobreviventes do que calculamos.";
        yield return StartCoroutine(esperar(5));
        texto1.text = "Pegue a munição em 110 segundos para prosseguir.";
        yield return StartCoroutine(esperar(5));
        texto1.text = "Câmbio e desligo.";
        yield return StartCoroutine(esperar(5));
        Debug.Log("Próxima fase!");
        SceneManager.LoadScene(4);

    }

   

    private IEnumerator esperar(float tempoEspera)
    {

        yield return new WaitForSeconds(tempoEspera);
    }
}
