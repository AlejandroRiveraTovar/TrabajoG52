using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class pregunta
{
    public string preguntaText;
    public string[] BRespuestas;
    public int respuestaCorrecta;
    public Sprite imagenPregunta;
    
}

[CreateAssetMenu(fileName = "New Categoria", menuName = "Quiz/QUestion Data")]


public class LeerVerdaderoFalso : ScriptableObject
{
    public string categoria;
    public pregunta[] preguntas;

}
