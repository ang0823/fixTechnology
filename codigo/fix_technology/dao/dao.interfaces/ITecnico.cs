using fix_technology.dao.dao.ef;
using System.Collections.Generic;

namespace fix_technology.dao.dao.interfaces
{
    interface ITecnico
    {
        List<string> obtenerNombresDeTecnicos();
        Tecnico obtenerTecnico(string nombreTecnico);
    }
}
