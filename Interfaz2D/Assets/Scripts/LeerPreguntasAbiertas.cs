using models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class LeerPreguntasAbiertas : MonoBehaviour
{

    private List<PreguntasAbiertas> preguntasAbiertasFaciles;
    
    string lineaLeidaFacil;

    public TextMeshProUGUI txtPreguntaFacil;
    public TextMeshProUGUI txtrespuestaFacil;
    string respuestaCorrectaFacil;

    private List<PreguntasAbiertas> preguntasAbiertasDificiles;
  
    string lineaLeidaDificil;

    public TextMeshProUGUI txtPreguntaDificil;
    public TextMeshProUGUI txtrespuestaDificil;
    string respuestaCorrectaDificil;

    public List<PreguntasAbiertas> PreguntasAbiertasFaciles { get => preguntasAbiertasFaciles; set => preguntasAbiertasFaciles = value; }
    public List<PreguntasAbiertas> PreguntasAbiertasDificiles { get => preguntasAbiertasDificiles; set => preguntasAbiertasDificiles = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Leer Preguntas Abiertas Faciles
    public void LeerpreguntasAbiertasFaciles()
    {
        try
        {
            StreamReader sr1 = new StreamReader("Assets/Resources/Files/ArchivoPreguntasAbiertas.txt");
            while ((lineaLeidaFacil = sr1.ReadLine()) != null)
            {
                string[] lineapartida = lineaLeidaFacil.Split("-");
                string preguntaFacil = lineapartida[0];
                string respuestaFacil = lineapartida[1];
                string respuestaCorrectaFacil = lineapartida[2];
                string versiculoFacil = lineapartida[3];
                string dificultadFacil = lineapartida[4];

                PreguntasAbiertas objPA = new PreguntasAbiertas(preguntaFacil, respuestaFacil,
                    respuestaCorrectaFacil, versiculoFacil, dificultadFacil);

                preguntasAbiertasFaciles.Add(objPA);

            }
            Debug.Log("Tamaño de la lista preguntas abiertas " + preguntasAbiertasFaciles.Count);
        }
        catch (Exception e)
        {
            Debug.Log("ERROR " + e.ToString());
        }
    }
    #endregion

    #region Leer Preguntas Abiertas Dificiles
    public void LeerpreguntasAbiertasDificiles()
    {
        try
        {
            StreamReader sr1 = new StreamReader("Assets/Resources/Files/ArchivoPreguntasAbiertas.txt");
            while ((lineaLeidaDificil = sr1.ReadLine()) != null)
            {
                string[] lineapartida = lineaLeidaDificil.Split("-");
                string preguntaDificil = lineapartida[0];
                string respuestaDificil = lineapartida[1];
                string respuestaCorrectaDificil = lineapartida[2];
                string versiculoDificil = lineapartida[3];
                string dificultadDificil = lineapartida[4];

                PreguntasAbiertas objPA = new PreguntasAbiertas(preguntaDificil, respuestaDificil, 
                    respuestaCorrectaDificil, versiculoDificil, dificultadDificil);

                preguntasAbiertasDificiles.Add(objPA);

            }
            Debug.Log("Tamaño de la lista preguntas abiertas " + preguntasAbiertasDificiles.Count);
        }
        catch (Exception e)
        {
            Debug.Log("ERROR " + e.ToString());
        }
    }

    #endregion
}
