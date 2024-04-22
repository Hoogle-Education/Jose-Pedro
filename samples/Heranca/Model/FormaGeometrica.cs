using System.Reflection.PortableExecutable;
using Heranca.Enums;

namespace Heranca.Model;

public abstract class FormaGeometrica
{
   public string Descricao {get; set;}
   public Color Cor { get; set; }

   public FormaGeometrica() {
   }

   public FormaGeometrica(Color cor) {
    Cor = cor;
   }

   public abstract double Area();

   public abstract double Perimetro();
}
