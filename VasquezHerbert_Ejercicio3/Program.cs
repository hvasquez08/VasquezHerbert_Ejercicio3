//Creacion del github
Console.WriteLine("QUE ES USTED?");
Console.WriteLine("Tipo de cliente\r\n1 Estudiante\r\n2 Docente\r\n3 Administrativo\r\n4 Externo");
int cliente = int.Parse(Console.ReadLine());
Console.WriteLine("Con que metodo paga?");
Console.WriteLine("Monto base\r\nMétodo de pago\r\n1 Efectivo\r\n2 Tarjeta\r\n3 Transferencia");
int pago = int.Parse(Console.ReadLine());
Console.WriteLine("Tiene cupongo?");
string cupo = Console.ReadLine();
