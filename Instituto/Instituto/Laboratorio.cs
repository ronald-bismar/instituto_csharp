using System;

namespace Instituto
{
	public class Laboratorio
	{
		protected string nroLab;
		protected int nroEquipos;
		protected string tipo;
		public Laboratorio()
		{
			nroLab = "24";
			nroEquipos = 10;
			tipo = "computacion";
		}
		public void leer(){
			Console.WriteLine();
			Console.WriteLine("Leyendo datos de Laboratorio");
			Console.Write("Introduzca numero de laboratorio: ");
			nroLab = Console.ReadLine();
			Console.Write("Introduzca numero de equipos: ");
			nroEquipos = int.Parse(Console.ReadLine());
			Console.Write("Introduzca tipo de laboratorio: ");
			tipo = Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine();
			Console.WriteLine("Mostrando datos de laboratorio");
			Console.WriteLine("Numero de laboratorio: "+nroLab);
			Console.WriteLine("Numero de equipos: "+nroEquipos);
			Console.WriteLine("Tipo de laboratorio: "+tipo);
		}
		public void setNroLab(string nroLab){
			this.nroLab = nroLab;
		}
		public string getNroLab(){
			return nroLab;
		}
		public void setNroEquipos(int nroEquipos){
			this.nroEquipos = nroEquipos;
		}
		public int getNroEquipos(){
			return nroEquipos;
		}
		public void setTipo(string tipo){
			this.tipo = tipo;
		}
		public string getTipo(){
			return tipo;
		}
	}
}
