using System;
using System.Collections.Generic;

namespace fix_technology.dao.interfaces
{
    interface ContratoDao
    {
        void actualizarContrato(Contrato contrato);
        List<Contrato> buscarPorNombreCliente(string nombreCliente);
        List<Contrato> buscarPorFechaDeRecepcion(DateTime fecha);
        List<Contrato> buscarPorModeloEquipo(string nombreModelo);
        List<Contrato> buscarPorNumeroDeSerie(string numeroSerie);
        List<Contrato> buscarPorNumeroDeServicio(string numeroServicio);
        int obtenerCantidadActualDeContratos();
        void registrar();
    }
}
