using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_Room_Digital
{
    public static class EstadoDeJuego
    {
        public static bool NivelNerdCompletado = false;
        public static bool NivelJesterCompletado = false;
        public static bool NivelShortSkeletonCompletado = false;
        public static bool NivelGhostCompletado = false;
        public static int cantidadNivelesCompletados = 0;
        public static bool HabloConLaTortuga = false;
        public static int VecesPresionado = 0;
        public static int TiempoRestanteNerd = 0;
        public static int TiempoRestanteGhost = 0;
        public static int TiempoRestanteShortSkeleton = 0;
    }
}
