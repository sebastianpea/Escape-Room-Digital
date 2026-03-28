using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_Room_Digital
{
    abstract class Acertijo
    {
        public string pregunta { get; set; }
        public int intentos { get; set; }
        public abstract bool ValidarRespuesta(string respuesta);
    }
}
