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
                Nombre = "LIGA DE QUITO",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0

            };

            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "BARCELONA SC",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0

            };
            Equipo idv = new Equipo
            {
                Id = 3,
                Nombre = "INDEPENDIENTE DEL VALLE",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0

            };
            Equipo Sdq = new Equipo
            {
                Id = 4,
                Nombre = "DEPORTIVO QUITO",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0

            };
            Equipo auc = new Equipo
            {
                Id = 5,
                Nombre = "AUCAS",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0

            };
            Equipo ore = new Equipo
            {
                Id = 6,
                Nombre = "ORENSE",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0

            };
            Equipo msh = new Equipo
            {
                Id = 7,
                Nombre = "MUSHUC RUNA",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0

            };
            equipos.Add(ldu);
            equipos.Add(bsc);
            equipos.Add(idv);
            equipos.Add(Sdq);
            equipos.Add(auc);
            equipos.Add(ore);
            equipos.Add(msh);

            equipos = equipos.OrderByDescending(item => item.TotalPuntos).ToList();

            return equipos; 
        }

        public Equipo DevuelveInformacionEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.First(item => item.Id == Id);
            return equipo;

        }

       
    }
}
