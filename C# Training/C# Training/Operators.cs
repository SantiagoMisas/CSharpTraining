
//Console.WriteLine("Ingrese el primer numero: ");
//var primerNumero = Console.ReadLine();

////if (primerNumero is null || primerNumero == "") {
////    Console.WriteLine("El valor es null");
////    return;
////}

////if (string.IsNullOrEmpty(primerNumero)) {
////    Console.WriteLine("Valor null o vacio");
////    return;
////}
//int primerNumeroInt = 0;
//if (!int.TryParse(primerNumero, out primerNumeroInt))
//{
//    Console.WriteLine("El valor ingresado no es un numero");
//    return;
//}

////var primerNumeroInt = int.Parse(primerNumero!);

//if (primerNumeroInt>=100 && primerNumeroInt <= 150)
//{
//    Console.WriteLine("El numero esta entre 100 y 150");
//}
//else
//{
//    Console.WriteLine("El numero es menor que 100 o mayor que 150");
//}

//Console.WriteLine("Ingrese el segundo numero");
//var segundoNumero = Console.ReadLine();
//var segundoNumeroInt = int.Parse(segundoNumero!);

//Console.WriteLine("Selecciona 1. Suma  2.Resta 3.Multiplicacion 4. Division");
////Va a intentar convertir a entero en el ? pregunta si es true entonces devuelve opcion
////en los : significa que si no entonces sera 0
//int opcion = int.TryParse(Console.ReadLine(), out opcion) ? opcion : 0;

//var total = 0;
//switch (opcion)
//{
//    case 1:
//        total = primerNumeroInt + segundoNumeroInt;
//        Console.WriteLine($"{primerNumeroInt} + {segundoNumeroInt} = {total}");
//        break;
//    case 2:
//        total = primerNumeroInt - segundoNumeroInt;
//        Console.WriteLine($"{primerNumeroInt} - {segundoNumeroInt} = {total}");
//        break;
//    case 3:
//        total = primerNumeroInt * segundoNumeroInt;
//        Console.WriteLine($"{primerNumeroInt} * {segundoNumeroInt} = {total}");
//        break;
//    case 4:
//        total = primerNumeroInt / segundoNumeroInt;
//        Console.WriteLine($"{primerNumeroInt} / {segundoNumeroInt} = {total}");
//        break;
//    default:
//        Console.WriteLine("Valor de error ingresado Debe ser un numero de 1 a 4");
//        return;
//}

//var resultadoSuma = primerNumeroInt;
//resultadoSuma += segundoNumeroInt;
//Console.WriteLine("Resultado de la suma: "+resultadoSuma);

//var resta = primerNumeroInt;
//resta -= segundoNumeroInt;
//Console.WriteLine($"Resultado de la resta: {resta}");

//var multiplicacion = primerNumeroInt * segundoNumeroInt;
//Console.WriteLine("Resultado de la multiplicacion: "+multiplicacion);

//var division = primerNumeroInt / segundoNumeroInt;
//Console.WriteLine("Resultado de la division: "+division);
