using fix_technology.dao.dao.ef;

namespace fix_technology.dao.dao.interfaces
{
    public interface ICliente
    {
        void actualizarInformacionCliente(int idCliente);
        bool esClienteExistente();
        Cliente obtenerCliente(int idClente);
    }
}
