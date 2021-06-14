using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public interface IContactoBLL
    {
        public void Agregar(Persona p);
        public List<Persona> Listar();
        public List<Persona> Listar(Clasificacion grupo);
    }
}
