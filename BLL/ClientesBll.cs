using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class ClientesBll
    {
        public static bool Guardar(Clientes cliente)
        {
            bool retorno = false;
            RegistroDb db = new RegistroDb();
            try
            {
                db.Cliente.Add(cliente);
                db.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public static bool Modificar(Clientes cliente)
        {
            bool retorno = false;
            RegistroDb db = new RegistroDb();
            try
            {
                db.Cliente.Add(cliente);
                db.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public static void Eliminar(int id)
        {
            RegistroDb db = new RegistroDb();
            Clientes cliente = Buscar(id);
            db.Cliente.Remove(cliente);
            db.SaveChanges();
        }

        public static Clientes Buscar(int id)
        {
            RegistroDb db = new RegistroDb();
            return db.Cliente.Find(id);
        }

        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();
            RegistroDb db = new RegistroDb();
            lista = db.Cliente.ToList();
            return lista;
        }

        public static List<Clientes> GetLista(int clienteId)
        {
            List<Clientes> lista = new List<Clientes>();
            RegistroDb db = new RegistroDb();
            lista = db.Cliente.Where(p => p.ClienteId == clienteId).ToList();
            return lista;
        }
    }
}
