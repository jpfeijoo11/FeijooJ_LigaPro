using FeijooJ_LigaPro.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FeijooJ_LigaPro.Repositorio
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
                TotalPuntos = 31,

            };

            Equipo bsc = new Equipo
            {
                Id = 1,
                Nombre = "BSC",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
                TotalPuntos = 31,

            };
            equipos.Add(ldu);
            equipos.Add(bsc);

            return equipos;
        }
        
    }
}
