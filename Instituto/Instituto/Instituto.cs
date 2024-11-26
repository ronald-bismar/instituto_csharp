using System;
namespace Instituto
{
	public class Instituto
	{
		private string ubicacion;
		private int cant_laboratorios;
		private int cant_talleres;
		private int cant_aulas;
		private Laboratorio []L = new Laboratorio[10];
		private Taller []T = new Taller[10];
		private Aula []A = new Aula[10];
		public Instituto()
		{
			ubicacion = "Zona 27 de  Abril";
			cant_laboratorios = 10;
			cant_talleres = 10;
			cant_aulas = 10;
			for (int i = 0; i < cant_laboratorios; i++)
				L[i] = new Laboratorio();
			for (int i = 0; i < cant_talleres; i++)
				T[i] = new Taller();
			for (int i = 0; i < cant_aulas; i++)
				A[i] = new Aula();
		}
		public void leer(){
			Console.WriteLine();
			Console.WriteLine("LEYENDO LOS DATOS DE INSTITUTO");
			Console.WriteLine("------------------------------");
			Console.Write("Ingrese ubicacion: ");
			ubicacion = Console.ReadLine();
			Console.Write("Ingrese la cantidad de laboratorios: ");
			this.cant_laboratorios = int.Parse(Console.ReadLine());
			Console.Write("Ingrese la cantidad de talleres: ");
			this.cant_talleres = int.Parse(Console.ReadLine());
			Console.Write("Ingrese la cantidad de aulas: ");
			this.cant_aulas = int.Parse(Console.ReadLine());
			for (int i = 0; i < cant_laboratorios; i++)
				L[i].leer();
			for (int i = 0; i < cant_talleres; i++)
				T[i].leer();
			for (int i = 0; i < cant_aulas; i++)
				A[i].leer();
		}
		public void mostrar(){
			Console.WriteLine();
			Console.WriteLine("MOSTRANDO DATOS DE INSTITUTO");
			Console.WriteLine("Ubicacion del instituto: "+ubicacion);
			Console.WriteLine("Cantidad de laboratorios: "+cant_laboratorios);
			Console.WriteLine("Cantidad de talleres: "+cant_talleres);
			Console.WriteLine("Cantidad de aulas: "+cant_aulas);
			for (int i = 0; i < cant_laboratorios; i++)
				L[i].mostrar();
			for (int i = 0; i < cant_talleres; i++)
				T[i].mostrar();
			for (int i = 0; i < cant_aulas; i++)
				A[i].mostrar();
			
		}
		
		//a) Adicionar “n” cantidad de sillas y “m” cantidad de mesas al aula “x”
		public void adicionarMesasSillas(){
			bool band = false;
			Console.Write("Introduzca la cantidad de sillas a añadir: ");
			int n = int.Parse(Console.ReadLine());
			Console.Write("Introduzca la cantidad de mesas a añadir: ");
			int m = int.Parse(Console.ReadLine());
			Console.Write("Introduzca el aula a la que quiere añadir sillas y mesas: ");
			string x = Console.ReadLine();
			for (int i = 0; i < cant_aulas; i++) {
				if((x).ToLower().Equals(A[i].getNroAula().ToLower())){
					A[i].adicionarMesasSillas(n, m);
					band = true;
					A[i].mostrar();
				}
			}
			if(band == false)
				Console.WriteLine("No se encontró el numero de aula ingresado");
		}
		
		//b) Buscar el taller nro "z" y cambiar su carrera por otra "y"
		public void cambiarCarreraTaller(){
			bool band = false;
			Console.WriteLine();
			Console.Write("Introduzca el nro de taller buscado: ");
			string z = Console.ReadLine();
			for (int i = 0; i < cant_talleres; i++) {
				if((z).ToLower().Equals(A[i].getNroAula().ToLower())){
					T[i].cambiarCarreraTaller();
					band = true;
					T[i].mostrar();
				}
			}
			if(band == false)
				Console.WriteLine("No se encontró el número de taller buscado");
		}
		//c) Si el área de taller es “x” mostrar a la carrera que pertenece
		public void mostrarCarreraTaller(){
			bool band = false;
			Console.WriteLine();
			Console.Write("Introduzca el area del taller: ");
			string x = Console.ReadLine();
			for (int i = 0; i < cant_talleres; i++) {
				if((x).ToLower().Equals(T[i].getArea().ToLower())){
					T[i].mostrarCarreraTaller();
					band = true;
				}
			}
			if(band == false)
				Console.WriteLine("No se encontró el número de taller buscado");
		}
		
		/*d) El nro de equipos del laboratorio “a” debe modificarse, ya que esta en manteamiento el
		10% de estos. Actualizar cuantos equipos están en uso*/
		public void actualizarNroEquiposLab(){
			bool band = false;
			Console.WriteLine();
			Console.WriteLine("ACTUALIZAR EQUIPOS EN LABORATORIO: ");
			Console.Write("Ingrese el nro de laboratorio: ");
			string a = Console.ReadLine();
			for (int i = 0; i < cant_laboratorios; i++) {
				if((a).ToLower().Equals(L[i].getNroLab().ToLower())){
					int equipos = L[i].getNroEquipos();
					int equiposActual = (int)(equipos-(equipos*0.10));
					L[i].setNroEquipos(equiposActual);
					band = true;
					Console.WriteLine("Cantidad actualizada de equipos:"+L[i].getNroEquipos());
				}
			}
			if(band == false)
				Console.WriteLine("No se encontró el nro de laboratorio");
		}
		//e) Mostrar la ubicación actual de la institución
		public void mostrarUbicacionInstituto(){
			Console.WriteLine();
			Console.Write("Ubicacion del instituto: "+ubicacion);
		}
	}
}
