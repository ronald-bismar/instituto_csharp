using System;

namespace Instituto
{
	public class Taller
	{
		protected string nroTaller;
		protected int carrera;
		protected string area;
		public Taller()
		{
			nroTaller = "4";
			carrera = 10;
			area = "diseño web";
		}
		public void leer(){
			Console.WriteLine();
			Console.WriteLine("Leyendo datos de Taller");
			Console.Write("Introduzca numero de taller: ");
			nroTaller = Console.ReadLine();
			Console.Write("Introduzca nro carrera: ");
			carrera = int.Parse(Console.ReadLine());
			Console.Write("Introduzca area: ");
			area = Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine();
			Console.WriteLine("Mostrando datos de Taller");
			Console.WriteLine("Numero de taller: "+nroTaller);
			Console.WriteLine("Carrera: "+carrera);
			Console.WriteLine("Area: "+area);
		}
		public void setNroTaller(string nroTaller){
			this.nroTaller = nroTaller;
		}
		public string getNroTaller(){
			return nroTaller;
		}
		public void setCarrera(int carrera){
			this.carrera = carrera;
		}
		public int getCarrera(){
			return carrera;
		}
		public void setArea(string area){
			this.area = area;
		}
		public string getArea(){
			return area;
		}
		//b) Buscar el taller nro "z" y cambiar su carrera por otra "y"
		public void cambiarCarreraTaller(){
			Console.WriteLine();
			Console.Write("Ingrese la nueva carrera: ");
			int y = int.Parse(Console.ReadLine());
			carrera = y;
		}
		//c) Si el área de taller es “x” mostrar a la carrera que pertenece
		public void mostrarCarreraTaller(){
			Console.WriteLine();
			Console.WriteLine("La carrera a la que pertenece el taller de "+area+" es: "+carrera);
		}
	}
}
