using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace models
{
    public class PreguntasAbiertas
    {
        private string pregunta;
        private string respuesta;
        private string respuestaCorrecta;
        private string versiculo;
        private string dificultad;

        public PreguntasAbiertas()
        {
        }

        public PreguntasAbiertas(string pregunta, string respuesta, string respuestaCorrecta, string versiculo, string dificultad)
        {
            this.pregunta = pregunta;
            this.respuesta = respuesta;
            this.respuestaCorrecta = respuestaCorrecta;
            this.versiculo = versiculo;
            this.dificultad = dificultad;
        }

        public string Pregunta { get => pregunta; set => pregunta = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        public string RespuestaCorrecta { get => respuestaCorrecta; set => respuestaCorrecta = value; }
        public string Versiculo { get => versiculo; set => versiculo = value; }
        public string Dificultad { get => dificultad; set => dificultad = value; }
    }
}