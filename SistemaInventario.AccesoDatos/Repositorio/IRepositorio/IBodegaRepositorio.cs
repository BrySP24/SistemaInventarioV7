﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaInventario.Modelos;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    // Implementacion del repositorio bodega 

    public interface IBodegaRepositorio : IRepositorio<Bodega> 
    {
        void Actualizar(Bodega bodega);
    }
    
}
 