using fix_technology.dao.dao.ef;

namespace fix_technology.dao.dao.interfaces
{
    interface IEquipo
    {
        void actualizarInformacionEquipo(string numeroSerie);
        bool esEquipoExistente(string numeroSerie);
        Equipo obtenerEquipo(string numeroSerie);
    }
}
