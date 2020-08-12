using fix_technology.dao.dao.ef;
using System;
using System.Collections.Generic;

namespace fix_technology.dao.dao.interfaces
{
    interface IServicio
    {
        void actualizarInformacion(string numeroServicio);
        List<Servicio> buscarPorNombreCliente(string nombre);
        List<Servicio> buscarPorFechaReciboDeEquipo(DateTime fecha);
        List<Servicio> buscarPorModeloDeEquipo(string modelo);
        List<Servicio> buscarPorNummeroServicio(string numeroServicio);
        List<Servicio> buscarPorNumeroDeSerieDeEquipo(string numeroSerie);
        int obtenerCantidadActual();
        void registrarNuevo(Servicio nuevo);
    }
}
