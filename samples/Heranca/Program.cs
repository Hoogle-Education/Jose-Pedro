using Heranca.Enums;
using Heranca.Model;

FormaGeometrica forma1 = new Circulo();
FormaGeometrica forma2 = new Retangulo(Color.BLUE);

Circulo circulo1 = (Circulo) forma1;
Circulo circulo2 = (Circulo) forma2; // errado