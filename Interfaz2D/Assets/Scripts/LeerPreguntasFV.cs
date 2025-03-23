using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class LeerPreguntasFV : MonoBehaviour
{

    private List<PreguntasFV> preguntasFVFaciles;

    string lineaLeidaFacil;

    public TextMeshProUGUI txtPreguntaFacil;
    public TextMeshProUGUI txtVerdaderoFacil;
    public TextMeshProUGUI txtFalsoFacil;
    string respuestaCorrectaFacil;

    private List<PreguntasFV> preguntasFVDificiles;

    string lineaLeidaDificil;

    public TextMeshProUGUI txtPreguntaDificil;
    public TextMeshProUGUI txtVerdaderoDificil;
    public TextMeshProUGUI txtFalsoDificil;
    string respuestaCorrectaDificil;


    public List<PreguntasFV> PreguntasFVFaciles { get => preguntasFVFaciles; set => preguntasFVFaciles = value; }
    public List<PreguntasFV> PreguntasFVDificiles { get => preguntasFVDificiles; set => preguntasFVDificiles = value; }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    #region Leer Preguntas Falso Verdadero Faciles
    public void LeerpreguntasFVFaciles()
    {
        try
        {
            StreamReader sr1 = new StreamReader("Assets/Resources/Files/ArchivoPreguntasFalso_Verdadero.txt");
            while ((lineaLeidaFacil = sr1.ReadLine()) != null)
            {
                string[] lineapartida = lineaLeidaFacil.Split("-");
                string preguntaFacil = lineapartida[0];
                string verdaderoFacil = lineapartida[1];
                string falsoFacil = lineapartida[2];
                string respuestaCorrectaFacil = lineapartida[3];
                string versiculoFacil = lineapartida[4];
                string dificultadFacil = lineapartida[5];

                PreguntasFV objPA = new PreguntasFV(preguntaFacil, verdaderoFacil, falsoFacil, 
                    respuestaCorrectaFacil, versiculoFacil, dificultadFacil);

                preguntasFVFaciles.Add(objPA);

            }
            Debug.Log("Tamaño de la lista preguntas FV " + preguntasFVFaciles.Count);
        }
        catch (Exception e)
        {
            Debug.Log("ERROR " + e.ToString());
        }
    }
    #endregion

    #region Leer Preguntas Falso Verdadero Dificiles
    public void LeerpreguntasFVDificiles()
    {
        try
        {
            StreamReader sr1 = new StreamReader("Assets/Resources/Files/ArchivoPreguntasFalso_Verdadero.txt");
            while ((lineaLeidaDificil = sr1.ReadLine()) != null)
            {
                string[] lineapartida = lineaLeidaDificil.Split("-");
                string preguntaDificil = lineapartida[0];
                string verdaderoDificil = lineapartida[1];
                string falsoDificil = lineapartida[2];
                string respuestaCorrectaDificil = lineapartida[3];
                string versiculoDificil = lineapartida[4];
                string dificultadDificil = lineapartida[5];

                PreguntasFV objPA = new PreguntasFV(preguntaDificil, verdaderoDificil, falsoDificil, 
                    respuestaCorrectaDificil, versiculoDificil, dificultadDificil);

                preguntasFVDificiles.Add(objPA);

            }
            Debug.Log("Tamaño de la lista preguntas FV " + preguntasFVDificiles.Count);
        }
        catch (Exception e)
        {
            Debug.Log("ERROR " + e.ToString());
        }
    }

    #endregion
}
