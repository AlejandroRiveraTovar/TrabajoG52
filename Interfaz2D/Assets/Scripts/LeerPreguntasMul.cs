using models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class LeerPreguntasM : MonoBehaviour
{

    private List<PreguntasMultiples> preguntasMultiplesFaciles; 

    string lineaLeidaFacil;

    public TextMeshProUGUI txtPreguntaFacil;
    public TextMeshProUGUI txtrespuesta1Facil;
    public TextMeshProUGUI txtrespuesta2Facil;
    public TextMeshProUGUI txtrespuesta3Facil;
    public TextMeshProUGUI txtrespuesta4Facil;
    string respuestaCorrectaFacil;

    private List<PreguntasMultiples> preguntasMultiplesDificiles;

    string lineaLeidaDificil;

    public TextMeshProUGUI txtPreguntaDificil;
    public TextMeshProUGUI txtrespuesta1Dificil;
    public TextMeshProUGUI txtrespuesta2Dificil;
    public TextMeshProUGUI txtrespuesta3Dificil;
    public TextMeshProUGUI txtrespuesta4Dificil;
    string respuestaCorrectaDificil;


    public List<PreguntasMultiples> PreguntasMultiplesFaciles { get => preguntasMultiplesFaciles; set => preguntasMultiplesFaciles = value; }
    public List<PreguntasMultiples> PreguntasMultiplesDiciles { get => preguntasMultiplesDificiles; set => preguntasMultiplesDificiles = value; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    #region Leer Preguntas Multiples Faciles
    public void LeerpreguntasMultiplesFaciles()
    {
        try
        {
            StreamReader sr1 = new StreamReader("Assets/Resources/Files/ArchivoPreguntasM.txt");
            while ((lineaLeidaFacil = sr1.ReadLine()) != null)
            {
                string[] lineapartida = lineaLeidaFacil.Split("-");
                string preguntaFacil = lineapartida[0];
                string respuesta1Facil = lineapartida[1];
                string respuesta2Facil = lineapartida[2];
                string respuesta3Facil = lineapartida[3];
                string respuesta4Facil = lineapartida[4];
                string respuestaCorrectaFacil = lineapartida[5];
                string versiculoFacil = lineapartida[6];
                string dificultadFacil = lineapartida[7];

                PreguntasMultiples objPM = new PreguntasMultiples(preguntaFacil, respuesta1Facil, respuesta2Facil,
                    respuesta3Facil, respuesta4Facil, respuestaCorrectaFacil, versiculoFacil, dificultadFacil);

                preguntasMultiplesFaciles.Add(objPM);

            }
            Debug.Log("Tamaño de la lista preguntas multiples " + preguntasMultiplesFaciles.Count);
        }
        catch (Exception e)
        {
            Debug.Log("ERROR " + e.ToString());
        }
    }
    #endregion

    #region Leer Preguntas Multiples Dificiles
    public void LeerpreguntasMultiplesDificiles()
    {
        try
        {
            StreamReader sr1 = new StreamReader("Assets/Resources/Files/ArchivoPreguntasM.txt");
            while ((lineaLeidaDificil = sr1.ReadLine()) != null)
            {
                string[] lineapartida = lineaLeidaDificil.Split("-");
                string preguntaDificil = lineapartida[0];
                string respuesta1Dificil = lineapartida[1];
                string respuesta2Dificil = lineapartida[2];
                string respuesta3Dificil = lineapartida[3];
                string respuesta4Dificil = lineapartida[4];
                string respuestaCorrectaDificil = lineapartida[5];
                string versiculoDificil = lineapartida[6];
                string dificultadDificil = lineapartida[7];

                PreguntasMultiples objPM = new PreguntasMultiples(preguntaDificil, respuesta1Dificil, respuesta2Dificil,
                    respuesta3Dificil, respuesta4Dificil, respuestaCorrectaDificil, versiculoDificil, dificultadDificil);

                preguntasMultiplesDificiles.Add(objPM);

            }
            Debug.Log("Tamaño de la lista preguntas multiples " + preguntasMultiplesDificiles.Count);
        }
        catch (Exception e)
        {
            Debug.Log("ERROR " + e.ToString());
        }
    }

    #endregion

}
