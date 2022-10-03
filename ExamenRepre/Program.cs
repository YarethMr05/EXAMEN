using ExamenRepre;

pllantilla uwu = new pllantilla();


Boolean salir = true;
string salida;
do
{
    
    uwu.datos();
   
    uwu.cambio();
    uwu.CantidadDeUnidades();
    uwu.imprimir();
   
  

    Console.WriteLine("desea salir si o no");
    salida = Console.ReadLine();
    if (salida == "si")
    {
        salir = true;
        Console.WriteLine(" adios vuelva pronto");
    }
    else
    {
        salir = false;
        Console.Clear();
    }
  


} while (salir != true);


