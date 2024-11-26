using System;

namespace Instituto
{
	public class Aula
	{
		protected string nroAula;
		protected int cantidadSillas;
		protected int cantidadMesas;
		public Aula()
		{
			nroAula = "24";
			cantidadSillas = 20;
			cantidadMesas = 20;
		}
		public void leer(){
			Console.WriteLine();
			Console.WriteLine("Leyendo datos de Aula");
			Console.Write("Introduzca numero de aula: ");
			nroAula = Console.ReadLine();
			Console.Write("Introduzca cantidad de sillas: ");
			cantidadSillas = int.Parse(Console.ReadLine());
			Console.Write("Introduzca cantidad de mesas: ");
			cantidadMesas = int.Parse(Console.ReadLine());
		}
		public void mostrar(){
			Console.WriteLine();
			Console.WriteLine("Mostrando datos de Aula");
			Console.WriteLine("Numero de aula: "+nroAula);
			Console.WriteLine("Cantidad de sillas: "+cantidadSillas);
			Console.WriteLine("Cantidad de mesas: "+cantidadMesas);
		}
		public void setNroAula(string nroAula){
			this.nroAula = nroAula;
		}
		public string getNroAula(){
			return nroAula;
		}
		public void setCantSillas(int cantidadSillas){
			this.cantidadSillas = cantidadSillas;
		}
		public int getCantSillas(){
			return cantidadSillas;
		}
		public void setCantMesas(int cantidadMesas){
			this.cantidadMesas = cantidadMesas;
		}
		public int getCantMesa(){
			return cantidadMesas;
		}
		
		//Adicionar “n” cantidad de sillas y “m” cantidad de mesas al aula “x”
		public void adicionarMesasSillas(int n, int m){
			cantidadSillas += n;
			cantidadMesas += m;
		}
	}
}
