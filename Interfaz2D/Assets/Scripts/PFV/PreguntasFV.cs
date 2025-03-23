using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace models
{
    public class PreguntasFV
    {
        private string pregunta;
        private string verdadero;
        private string falso;
        private string respuestaCorrecta;
        private string versiculo;
        private string dificultad;

        public PreguntasFV()
        {
        }

        public PreguntasFV(string pregunta, string verdadero, string falso, string respuestaCorrecta, string versiculo, string dificultad)
        {
            this.pregunta = pregunta;
            this.verdadero = verdadero;
            this.falso = falso;
            this.respuestaCorrecta = respuestaCorrecta;
            this.versiculo = versiculo;
            this.dificultad = dificultad;
        }

        public string Pregunta { get => pregunta; set => pregunta = value; }
        public string Verdadero { get => verdadero; set => verdadero = value; }
        public string Falso { get => falso; set => falso = value; }
        public string RespuestaCorrecta { get => respuestaCorrecta; set => respuestaCorrecta = value; }
        public string Versiculo { get => versiculo; set => versiculo = value; }
        public string Dificultad { get => dificultad; set => dificultad = value; }
    }

}
