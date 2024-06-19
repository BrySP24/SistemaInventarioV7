using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaInventario.Modelos;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    // Implementacion del repositorio marca

    public interface IMarcaRepositorio : IRepositorio<Marca> 
    {
        void Actualizar(Marca marca);
    }
    
}
 