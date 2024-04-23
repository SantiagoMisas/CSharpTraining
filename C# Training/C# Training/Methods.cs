//void ImprimirTexto() {
//	Console.WriteLine("Metodo void sin retorno");
//};

//ImprimirTexto();

//void imprimirNumeroAleatorio(int rango = 4, string mensaje ="parametro default") {

//	var random = new Random();

//	for (int i=1; i<=rango;i++) { 
//		var numeroAleatorio = random.Next(1, 2000);
//		Console.WriteLine($"{mensaje}} {numeroAleatorio}");
//    }
//};

//imprimirNumeroAleatorio(50, "El numero aleatorio es");

//imprimirNumeroAleatorio(rango: 5, mensaje: "parametro");

//double salarioNeto;

//void calcularSalario(double salario, double impuesto, double salud, out double salarioNeto){

//salarioNeto = salario - impuesto - salud;
  
//}

//double calculo;
//calcularSalario(salario: 1300000, impuesto: 51000, salud: 95000, calculo);
//Console.WriteLine($"El salario neto es: {calculo}");

string obtenerEdad(int edad) {

    try
    {
        if (edad>0 && edad<18 )
        {
            return "Menor de edad";
        }
        else
        {
            return "Mayor de edad";
        }
    }
    catch (Exception e) {
        Console.WriteLine(e.Message);
    }
}

var mensaje=obtenerEdad(19);
Console.WriteLine($"El sujeto es: {mensaje}")