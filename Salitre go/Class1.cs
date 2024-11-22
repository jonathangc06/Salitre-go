using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salitre_go;

public class Atraccion
{
    public string Titulo { get; set; }
    public string Imagen { get; set; }
    public string Descripcion { get; set; }

    public string Estado { get; set; }
    public string Tipo { get; set; }
    public string Restricciones { get; set; }

    public Atraccion(string titulo, string imagen, string descripcion, string estado, string tipo, string restricciones)
    {
        Titulo = titulo;
        Imagen = imagen;
        Descripcion = descripcion;
        Estado = estado;
        Tipo = tipo;
        Restricciones = restricciones;
    }
}
