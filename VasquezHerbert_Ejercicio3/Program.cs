//Creacion del github
Console.WriteLine("Tipo de cliente\r\n1 Estudiante\r\n2 Docente\r\n3 Administrativo\r\n4 Externo");
int cliente = int.Parse(Console.ReadLine());
Console.WriteLine("Con que metodo paga?");
Console.WriteLine("Monto base\r\nMétodo de pago\r\n1 Efectivo\r\n2 Tarjeta\r\n3 Transferencia");
int pago = int.Parse(Console.ReadLine());
Console.WriteLine("Monto a pagar");
int monto = int.Parse(Console.ReadLine());
Console.WriteLine("Tiene cupongo?");
string cupo = Console.ReadLine();
// para el codigo de cupon el cupon se valido se necesita que si se devide en 2 y el resultado es 0
Console.WriteLine("Ingrese codigo");
double codigo = double.Parse(Console.ReadLine());
double descueto = 0;
double descuentocupon = 0;
double recargo = 0;
if (cliente >=1 && cliente <=4 && pago >= 1 && pago <= 3) { 
switch (cliente)
{
    case 1://Estudiante
        descueto = monto * 0.10;
        break;
    case 2://docente
        descueto = monto * 0.15;
        break;
    case 3://administrativo
        descueto = monto * 0.10;
        break;
    case 4: //extreno
        descueto = monto * 0.05;
        break;
    default://error
        Console.WriteLine("error");
        break;
}
switch (pago)
{
    case 1: //efectivo
        if (cupo == "S")
        {
            if (codigo % 2 == 0)
            {
                descuentocupon = monto * 0.10;
            }
            else
            {
                recargo = monto * 10;
            }
        }
        else
        {
            descuentocupon = monto * 0.05;
        }
        break;
    case 2://tarjeta
        if (cupo == "S")
        {
            if (codigo % 2 == 0)
            {
                descuentocupon = monto * 0.10;
            }
            else
            {
                recargo = monto * 10;
            }
        }
        else
        {
            descuentocupon = monto * 0.05;
        }
        break;
    case 3://transferencia
        if (cupo == "S")
        {
            if (codigo % 2 == 0)
            {
                descuentocupon = monto * 0.10;
            }
            else
            {
                recargo = monto * 10;
            }
        }
        else
        {
            descuentocupon = monto * 0.05;
        }
        break;

    default://Error
        Console.WriteLine("erroe");
        break;

}
Console.WriteLine("facturas");
Console.WriteLine($"Descueto por ser alguien = {descueto} ");
Console.WriteLine($"Descueto por cupon=╧{descuentocupon}");
Console.WriteLine($"recargo por abusivo={recargo}");
Console.WriteLine($"Monto final={monto-descueto-descuentocupon+recargo}");
    //se cambio todo el enfoque ya que me di cuenta que iba a hacer un codigo gigante el cual no me pide jajsjaj
}
else
{
    Console.WriteLine("datos erroneos");
}