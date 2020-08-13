using fix_technology.dao.dao.ef;
using fix_technology.dao.dao.interfaces;
using System;
using System.Data;
using System.Linq;

namespace fix_technology.dao
{
    class ClienteDao : ICliente
    {
        ftContext database;

        public void actualizarInformacionCliente(int idCliente)
        {
            database = new ftContext();

            try
            {
                Cliente cliente = database.Cliente.Find(idCliente);
                cliente.nombre = "";
                cliente.apellido_paterno = "";
                cliente.apellido_materno = "";
                cliente.telefono = "";
                cliente.email = "";
                database.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                database.Dispose();
            }
        }

        public bool esClienteExistente()
        {
            database = new ftContext();
            bool esExistente = false;

            try
            {
                Cliente cliente;
                cliente = (from client in database.Cliente 
                        where client.nombre == "" 
                        && client.apellido_paterno == "" 
                        && client.apellido_materno == ""
                        && client.telefono == ""
                        && client.email == ""
                        && client.id_direccion == 0
                        select client).FirstOrDefault();
                
                if(cliente != null)
                {
                    esExistente = true;
                }

            }catch(Exception e)
            {
                throw e;
            }
            finally
            {
                database.Dispose();
            }

            return esExistente;
        }

        public Cliente obtenerCliente(int idClente)
        {
            database = new ftContext();
            Cliente cliente;

            try
            {
                cliente = (from client in database.Cliente
                           where client.id == idClente 
                           select client).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                database.Dispose();
            }

            return cliente;
        }
    }
}