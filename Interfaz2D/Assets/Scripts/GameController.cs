using models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class GameController : MonoBehaviour
{



    PreguntasMultiples PM;
    PreguntasFV PFV;
    PreguntasAbiertas PA;
    List<PreguntasMultiples> listaPM;
    List<PreguntasFV> listaPFV;
    List<PreguntasAbiertas> listaPA;
    string lineaLeida; 




    public List<GameObject> ListaGameObjects;
    // Start is called before the first frame update
    private LeerPreguntasFV lectorFV;
    private LeerPreguntasAbiertas lectorPA;
    private LeerPreguntasM lectorPM;

    private bool esRondaFacil = true;
    private int respuestasCorrectas = 0;
    private int respuestasIncorrectas = 0;
    private int indiceActualdePreguntas = 0;
    private List<GameObject> preguntaRondaActual;


    private List<GameObject> preguntasFaciles = new List<GameObject>();
    private List<GameObject> preguntasDificiles = new List<GameObject>();
    private List<GameObject> listaActualPreguntas;

    void Start()
    {
        lectorPA = GetComponent<LeerPreguntasAbiertas>();
        lectorFV = GetComponent<LeerPreguntasFV>();
        lectorPM = GetComponent<LeerPreguntasM>();

        CargarPregunta();
        

        RondaFacil();



    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CargarPregunta()
    {
        if (lectorPA.PreguntasAbiertasFaciles == null)
            lectorPA.PreguntasAbiertasFaciles = new List<PreguntasAbiertas>();

        if (lectorPA.PreguntasAbiertasDificiles == null)
            lectorPA.PreguntasAbiertasDificiles = new List<PreguntasAbiertas>();

        if (lectorFV.PreguntasFVFaciles == null)
            lectorFV.PreguntasFVFaciles = new List<PreguntasFV>();

        if (lectorFV.PreguntasFVDificiles == null)
            lectorFV.PreguntasFVDificiles = new List<PreguntasFV>();

        if (lectorPM.PreguntasMultiplesFaciles == null)
            lectorPM.PreguntasMultiplesFaciles = new List<PreguntasMultiples>();

        if (lectorPM.PreguntasMultiplesDiciles == null)
            lectorPM.PreguntasMultiplesDiciles = new List<PreguntasMultiples>();

        lectorPA.LeerpreguntasAbiertasFaciles();
        lectorPA.LeerpreguntasAbiertasDificiles();
        lectorFV.LeerpreguntasFVFaciles();
        lectorFV.LeerpreguntasFVDificiles();
        lectorPM.LeerpreguntasMultiplesFaciles();
        lectorPM.LeerpreguntasMultiplesDificiles();

        Debug.Log("Todas las preguntas han sido cargadas");

    }
    private void RondaFacil()
    {
        esRondaFacil = true;
        indiceActualdePreguntas = 0;

        preguntaRondaActual = new List<GameObject>();
        foreach (var pregunta in lectorPA.PreguntasAbiertasFaciles)
        {
            GameObject ObjPA = new GameObject("PreguntaAbierta");
            ObjPA.AddComponent<LeerPreguntasAbiertas>();
            var component = ObjPA.GetComponent<PreguntasAbiertas>();
            component.Pregunta = pregunta.Pregunta;
            component.Respuesta = pregunta.Respuesta;
            component.RespuestaCorrecta = pregunta.RespuestaCorrecta;
            component.Versiculo = pregunta.Versiculo;
            component.Dificultad = pregunta.Dificultad;
            preguntaRondaActual.Add(ObjPA);

        }

        foreach (var pregunta in lectorFV.PreguntasFVFaciles)
        {
            GameObject objPFV = new GameObject("PreguntaFV");
            objPFV.AddComponent<LeerPreguntasFV>();
            var component = objPFV.GetComponent<PreguntasFV>();
            component.Pregunta = pregunta.Pregunta;
            component.Verdadero = pregunta.Verdadero;
            component.Falso = pregunta.Falso;
            component.RespuestaCorrecta = pregunta.RespuestaCorrecta;
            component.Versiculo = pregunta.Versiculo;
            component.Dificultad = pregunta.Dificultad;
            preguntaRondaActual.Add(objPFV);

        }

        foreach (var pregunta in lectorPM.PreguntasMultiplesFaciles)
        {
            GameObject objPM = new GameObject("PreguntaMultiple");
            objPM.AddComponent<LeerPreguntasM>();
            var component = objPM.GetComponent<PreguntasMultiples>();
            component.Pregunta = pregunta.Pregunta;
            component.Respuesta1 = pregunta.Respuesta1;
            component.Respuesta2 = pregunta.Respuesta2;
            component.Respuesta3 = pregunta.Respuesta3;
            component.Respuesta4 = pregunta.Respuesta4;
            component.RespuestaCorrecta = pregunta.RespuestaCorrecta;
            component.Versiculo = pregunta.Versiculo;
            component.Dificultad = pregunta.Dificultad;
            preguntaRondaActual.Add(objPM);

        }

        PreguntasAleatorias(preguntaRondaActual);

        Debug.Log("Ronda Facil"+ preguntaRondaActual.Count + "Preguntas");
        MostrarSiguientePregunta();
    }

    private void RondaDificil()
    {
        esRondaFacil = true;
        indiceActualdePreguntas = 0;

        preguntaRondaActual = new List<GameObject>();
        foreach (var pregunta in lectorPA.PreguntasAbiertasDificiles)
        {
            GameObject objPA = new GameObject("PreguntaAbierta");
            objPA.AddComponent<LeerPreguntasAbiertas>();
            var component = objPA.GetComponent<PreguntasAbiertas>();
            component.Pregunta = pregunta.Pregunta;
            component.Respuesta = pregunta.Respuesta;
            component.RespuestaCorrecta = pregunta.RespuestaCorrecta;
            component.Versiculo = pregunta.Versiculo;
            component.Dificultad = pregunta.Dificultad;
            preguntaRondaActual.Add(objPA);

        }

        foreach (var pregunta in lectorFV.PreguntasFVDificiles)
        {
            GameObject objFV = new GameObject("PreguntaFV");
            objFV.AddComponent<LeerPreguntasFV>();
            var component = objFV.GetComponent<PreguntasFV>();
            component.Pregunta = pregunta.Pregunta;
            component.Verdadero = pregunta.Verdadero;
            component.Falso = pregunta.Falso;
            component.RespuestaCorrecta = pregunta.RespuestaCorrecta;
            component.Versiculo = pregunta.Versiculo;
            component.Dificultad = pregunta.Dificultad;
            preguntaRondaActual.Add(objFV);

        }

        foreach (var pregunta in lectorPM.PreguntasMultiplesDiciles)
        {
            GameObject ObjPM = new GameObject("PreguntaMultiple");
            ObjPM.AddComponent<LeerPreguntasM>();
            var component = ObjPM.GetComponent<PreguntasMultiples>();
            component.Pregunta = pregunta.Pregunta;
            component.Respuesta1 = pregunta.Respuesta1;
            component.Respuesta2 = pregunta.Respuesta2;
            component.Respuesta3 = pregunta.Respuesta3;
            component.Respuesta4 = pregunta.Respuesta4;
            component.RespuestaCorrecta = pregunta.RespuestaCorrecta;
            component.Versiculo = pregunta.Versiculo;
            component.Dificultad = pregunta.Dificultad;
            preguntaRondaActual.Add(ObjPM);

        }

        PreguntasAleatorias(preguntaRondaActual);

        Debug.Log("Ronda Facil" + preguntaRondaActual.Count + "Preguntas");
        MostrarSiguientePregunta();
    }

   private void PreguntasAleatorias(List<GameObject> list)
    {
        System.Random rng = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            GameObject value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
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
            if (indiceActualdePreguntas >= preguntaRondaActual.Count)
            {
                if (esRondaFacil)
                {
                    RondaDificil();
                }
                else
                {
                    MostrarResultadosFinales();
                }
                return;
            }

            MostrarPreguntaAbierta(gameObject.GetComponent<PreguntasAbiertas>());

           

        }
        if (gameObject.GetComponent<PreguntasMultiples>() != null)
        {
            //Aqui va la logica de las preguntas multiples

            if (indiceActualdePreguntas >= preguntaRondaActual.Count)
            {
                if (esRondaFacil)
                {
                    RondaDificil();
                }
                else
                {
                    MostrarResultadosFinales();
                }
                return;
            }

            MostrarPreguntaMultiple(gameObject.GetComponent<PreguntasMultiples>());
        }
        if (gameObject.GetComponent<PreguntasFV>() != null)
        {
            //Aqui va la logica de las preguntas FV
            if (indiceActualdePreguntas >= preguntaRondaActual.Count)
            {
                if (esRondaFacil)
                {
                    RondaDificil();
                }
                else
                {
                    MostrarResultadosFinales();
                }
                return;
            }

            MostrarPreguntaFV(gameObject.GetComponent<PreguntasFV>());
        }
        indiceActualdePreguntas++;
    }

    private void MostrarPreguntaFV(PreguntasFV preguntasFV)
    {
        throw new NotImplementedException();
    }

    private void MostrarPreguntaMultiple(PreguntasMultiples preguntasMultiples)
    {
        throw new NotImplementedException();
    }

    private void MostrarPreguntaAbierta(PreguntasAbiertas preguntasAbiertas)
    {
        throw new NotImplementedException();
    }

    private void MostrarResultadosFinales()
    {
        
    }
    private void MostrarSiguientePregunta()
    {
        if (indiceActualdePreguntas>= preguntaRondaActual.Count)
        {
            if (esRondaFacil)
            {
                Debug.Log("Ronda de Preguntas Fáciles Completada. Comenzando Ronda de Preguntas Dificiles");
                RondaDificil();
            }
            else
            {
                Debug.Log("Juego Terminado");
                MostrarResultadosFinales();
            }
        }
        else
        {
            LogicaJuego();
        }
    }

}
