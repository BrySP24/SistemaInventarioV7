using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SistemaInventario.Modelos.Especificaciones
{
    public class PagedList<T> : List<T>
    {
        public Metadata Metadata { get; set; }

        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            Metadata = new Metadata
            {
                TotalCount = count,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize) // por ejemplo 1.5 lo tranformaria a 2

            };
            AddRange(items); //Agrega los elementos de la coleccion al final de la lista
        }

        public static PagedList<T>  ToPagedList(IEnumerable<T> entidad, int pageNumber, int pageSize) 
        {
            var count = entidad.Count();
            var items = entidad.Skip((pageNumber -1) * pageSize).Take(pageSize).ToList();
            return new  PagedList<T>(items, count, pageNumber, pageSize);
        }
    }
}
