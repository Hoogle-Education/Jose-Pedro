
using Heranca.Enums;

namespace Heranca.Model;

public class Retangulo : FormaGeometrica
{
   public double Altura { get; set; }
   public double Comprimento { get; set; }

   public Retangulo(Color cor) : base(cor) {
   }
}
