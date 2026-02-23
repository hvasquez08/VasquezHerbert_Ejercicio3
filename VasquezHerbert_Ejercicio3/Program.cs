//Creacion del github
Console.WriteLine("QUE ES USTED?");
Console.WriteLine("Tipo de cliente\r\n1 Estudiante\r\n2 Docente\r\n3 Administrativo\r\n4 Externo");
int cliente = int.Parse(Console.ReadLine());
Console.WriteLine("Con que metodo paga?");
Console.WriteLine("Monto base\r\nMétodo de pago\r\n1 Efectivo\r\n2 Tarjeta\r\n3 Transferencia");
int pago = int.Parse(Console.ReadLine());
Console.WriteLine("Tiene cupongo?");
string cupo = Console.ReadLine();
switch (cliente)
{
    case 1://Estudiante
        switch (pago)
        {
            case 1: //efectivo
                break;
            case 2://tarjeta
                break;
            case 3://transferencia
                break;
            default://Error
                break;

        }


        break;
    case 2://docente
        break;
    case 3://administrativo
        break;
    case 4: //extreno
        break;
    default://error
        break;
}
