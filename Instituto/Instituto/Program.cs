using System;

namespace Instituto
{
	class Program
	{
		public static void Main(string[] args)
		{
			Instituto I = new Instituto();
			//I.mostrar();
			I.leer();
			I.mostrar();
			
			//a) Adicionar “n” cantidad de sillas y “m” cantidad de mesas al aula “x”
			//I.adicionarMesasSillas();
			
			//b) Buscar el taller nro "z" y cambiar su carrera por otra "y"
			I.cambiarCarreraTaller();
			
			//c) Si el área de taller es “x” mostrar a la carrera que pertenece
			//I.mostrarCarreraTaller();
			
			/*d) El nro de equipos del laboratorio “a” debe modificarse, ya que esta en manteamiento el
			10% de estos. Actualizar cuantos equipos están en uso*/
			//I.actualizarNroEquiposLab();
			
			//e) Mostrar la ubicación actual de la institución
			//I.mostrarUbicacionInstituto();
			
			Console.ReadKey(true);
		}
	}
}