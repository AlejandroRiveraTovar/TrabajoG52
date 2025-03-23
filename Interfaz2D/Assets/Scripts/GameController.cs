using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<GameObject> ListaGameObjects;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LogicaJuego()
    {
        //Random para sacar un valor de 0 hasta el tamaño de listaGameObjects.count
        int random = 0;
        //Va a ir una lista de GamObject y sacar un elemento de esa lista
        GameObject gameObject = ListaGameObjects[random];
        if (gameObject.GetComponent<PreguntasAbiertas>() != null)
        {
            //Aqui va la logica de las preguntas abiertas
        }
        if (gameObject.GetComponent<PreguntasMultiples>() != null)
        {
            //Aqui va la logica de las preguntas multiples
        }
        if (gameObject.GetComponent<PreguntasFV>() != null)
        {
            //Aqui va la logica de las preguntas FV
        }
    }

}
