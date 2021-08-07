using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
            INICIO:
            int opcion;
            Console.WriteLine("Seleccione ejercicio\n (1, 2 , 3, o 4)");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
					Console.WriteLine("Laberinto");
					var reader = new StreamReader("Maze 2 LVL 1.csv");
					char[,] matriz = new char[19, 19];

                    try
                    {
						while (!reader.EndOfStream)
						{
							var linea = reader.ReadLine();
							var valores = linea.Split(",");

							for (int i = 0; i < 19; i++)
							{

								for (int j = 0; j < 19; j++)
								{

									matriz[i, j] = Convert.ToChar(valores[j]);

								}
							}
						}
					}
                    catch (Exception)
                    {
						Console.WriteLine("Ejercicio no resuelto");
						Console.ReadKey();
						Console.Clear();
						goto INICIO;
					
                    }
					

					Console.ReadKey();
					Console.Clear();
					goto INICIO;
                    

                case 2:

					Console.WriteLine("Impresora de puntos");
					var lector = new StreamReader("prueba problema2.csv");

                    while (!lector.EndOfStream)
                    {
						var linea = lector.ReadLine();
						var valores = linea.Split(',');

						if (valores[0] == "1")
                        {
							int cateto = Convert.ToInt32(valores[1]);
							for (int y = 1; y <= cateto; y++)
							{
								for (int x = 1; x <= y; x++)
								{
									Console.Write("*");
								}
								Console.WriteLine();
							}
						}
						else if (valores[0] == "2")
                        {
							try
							{
								int nivel = Convert.ToInt32(valores[1]);
								int x;
								int espacios;
								for (int i = 0; i < nivel; i++)
								{
									StringBuilder final = new StringBuilder();

									espacios = nivel - i;
									x = i + (i - 1);
									for (int i1 = 0; i1 < espacios; i1++)
										final.Append(" ");

									for (int i2 = 0; i2 < x; i2++)
										final.Append("*");

									Console.WriteLine(final.ToString());

								}
							}
							catch (Exception)
							{
								
							}
						}
						else if (valores[0] == "3")
						{
							//rombo

							int i, j, ancho;
							ancho = Convert.ToInt32(valores[1]);

							for (i = 0; i <= ancho; i++)
							{
								for (j = ancho - i; j > 0; j--)
								{
									Console.Write(" ");
								}
								for (j = 0; j < i; j++)
								{
									Console.Write(" *");

								}
								Console.WriteLine();
							}

							for (i = 0; i <= ancho; i++)
							{
								for (j = 0; j <= i; j++)
								{
									Console.Write(" ");
								}
								for (j = ancho - i - 1; j > 0; j--)
								{
									Console.Write(" *");

								}
								Console.WriteLine(" ");
							}
						}
						else if (valores[0] == "4")
						{
							Console.WriteLine();
							int lado = Convert.ToInt32(valores[1]);
							for (int i = 1; i<=lado; i++)
                            {
								for(int j = 1; j<=lado; j++)
                                {
									Console.Write("* ");	
                                }
								Console.WriteLine(" ");
                            }
						}
					}
					Console.ReadKey();
					Console.Clear();
					goto INICIO;

                  

                case 3:
					//Ecuaciones cuadraticas

					Console.WriteLine("Calculadora de ecuaciones cuadráticas");
					double a = 0;
					double b = 0;
					double c = 0;
					double formula = 0;
					double solucion1 = 0;
					double solucion2 = 0;



					while (a == 0)
                    {
						try
						{

							Console.WriteLine("Introduce el numero A");
							a = Convert.ToDouble(Console.ReadLine());

						}
						catch (Exception error)

						{
							Console.WriteLine(error.Message);
						}
					}

					while (b == 0)
					{
						try
						{

							Console.WriteLine("Introduce el numero B");
							b = Convert.ToDouble(Console.ReadLine());

						}
						catch (Exception error)

						{
							Console.WriteLine(error.Message);
						}
					}

					while ( c == 0)
					{
						try
						{

							Console.WriteLine("Introduce el numero C");
							c = Convert.ToDouble(Console.ReadLine());

						}
						catch (Exception error)

						{
							Console.WriteLine(error.Message);
						}
					}


					//chicharronera
					formula = b * b - 4 * a * c;

					if (formula < 0)
					{
						Console.WriteLine("solucion no real");
						formula = -formula;
					}
					else
						Console.WriteLine("Existen soluciones reales");

					solucion1 = Math.Round((-b + Math.Sqrt(formula)) / (2 * a),2);
					solucion2 = Math.Round((-b - Math.Sqrt(formula)) / (2 * a), 2);
					Console.WriteLine("x1 =" + " " + solucion1);
					Console.WriteLine("x2 =" + " " + solucion2);

					Console.ReadKey();
					Console.Clear();
					goto INICIO;
			

			

                case 4:
                    //triangulo pascal 

                    int altura;
                   
                    Console.WriteLine("Triangulo de Pascal");
                    Console.WriteLine("Ingrese altura del triangulo");
                    altura = Convert.ToInt32( Console.ReadLine());
                    int[,] matrizTriangulo = new int[altura, altura];

                    for (int i = 0; i < altura; i++)
                    {
                        matrizTriangulo[i, 0] = 1;
                    }
                    for (int i = 0; i < altura; i++)
                    {
                        matrizTriangulo[i, i] = 1;
                    }
                    for (int i = 2; i< altura; i++)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            matrizTriangulo[i, j] = matrizTriangulo[i - 1, j] + matrizTriangulo[i - 1, j - 1];
                        }
                    }
                    for (int i = 0; i < altura; i++)
                    {
                        string resultado = "";
                        for (int j = 0; j<= i; j++)
                        {
                            resultado += matrizTriangulo[i, j]+ " ";
                        }
                        Console.WriteLine(resultado);
                    }

                    Console.ReadKey();
					Console.Clear();
					goto INICIO;
                  
            }



        }
    }
}
