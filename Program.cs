using System.Collections.Generic; 
int puntos;
System.Console.WriteLine("Que punto desea ver? 1 , 2 , 3 o 4 ");
puntos = int.Parse(Console.ReadLine());
switch (puntos)
{
    case 1:
    punto1();
    break;
    case 2:
    punto2();
    break;
    case 3:
    punto3();
    break;
    case 4:
    punto4();
    break;
    default:
    System.Console.WriteLine("Punto no valido! ");
    break;
}

void punto1(){
int[] meses =  {0,1,2,3,4,5,6,7,8,9,10,11,12};
int[] dias = {0,31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
int valiMes, valiDias;
DateTime diaHoy  = DateTime.Now;
valiMes = validarMesDelCumple();
valiDias = validarDiaDelCumple(dias, meses,valiMes);
DateTime cumpleaños = new DateTime( 2023,valiMes,valiDias);
System.Console.WriteLine(cumpleaños);
cuantosDiasFaltan( diaHoy,  cumpleaños);

int validarMesDelCumple()


{
    int mesCumple;
System.Console.WriteLine("En que mes cumplis? ");
mesCumple = int.Parse(Console.ReadLine());
while(mesCumple <= 0 || mesCumple > 12 )
{
 System.Console.WriteLine("Por favor volver a ingresar mes, mes no valido! ");
 mesCumple = int.Parse(Console.ReadLine());
}
return mesCumple;
} 
int validarDiaDelCumple(int[]dias, int[]meses, int valiMes)

{
    int diaCumple;
    System.Console.WriteLine("Ingrese el dia de su cumple: ");
    diaCumple = int.Parse(Console.ReadLine());
    while(diaCumple<= 0 || diaCumple > dias[valiMes])
    {
        System.Console.WriteLine("El dia que ingresaste no existe en ese mes, volve a ingresarlo! ");
        diaCumple = int.Parse(Console.ReadLine());
    }
return diaCumple;

}
void cuantosDiasFaltan(DateTime diaHoy, DateTime cumpleaños)
{
    DateTime fecha = cumpleaños;
    if(cumpleaños>diaHoy)
    {
       System.Console.WriteLine("Faltan: "+fecha.Subtract(diaHoy).Days+ " dias");
    }
    else if(cumpleaños<diaHoy)
    {
        System.Console.WriteLine("Ya pasaron: "+ Math.Abs(fecha.Subtract(diaHoy).Days)+ " dias");
    }
    else if (cumpleaños==diaHoy)
    {
        System.Console.WriteLine("Feliz cumple!!");

    }
}
}
void punto2(){
//2
int[] dias = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
int dia,cuotas, mesFecha;
mesFecha = 0;
DateTime fecha = recibirDiaMes();
cuotas = validarCuotas(mesFecha);
List <DateTime> fechaPag = obtenerFechasPago(cuotas,fecha);
for (int i = 0; i < fechaPag.Count(); i++)
{
    System.Console.WriteLine(fechaPag[i]);
}
DateTime recibirDiaMes()
{
           int mesFecha ;
            System.Console.WriteLine("ingrese el mes de la compra:  ");
         mesFecha = int.Parse(Console.ReadLine());
          while(mesFecha <= 0 || mesFecha > 12 )
        {
            System.Console.WriteLine("Por favor volver a ingresar mes, mes no valido! ");
            mesFecha = int.Parse(Console.ReadLine());
        }
            Console.WriteLine("Ingrese el dia de la compra: ");
            dia = int.Parse(Console.ReadLine());
            while (dia <= 0 || dia > dias[mesFecha])
            {
                Console.WriteLine("No hay un dia en ese mes, volve a ingresarlo!!! ");
                dia = int.Parse(Console.ReadLine());
            }
            DateTime fecha = new DateTime( 2023,mesFecha,dia);
            return fecha;
}
int validarCuotas(int mesFecha)
{
    int cuotas;
    System.Console.WriteLine("Ingrese la cangtidad de cuotas que desee hacer: ");
    cuotas = int.Parse(Console.ReadLine());
    while(cuotas <0)
    {
        System.Console.WriteLine("No existe es cantidad de cuotas, volve a ingresar una cantidad de ellas!!! ");
        cuotas = int.Parse(Console.ReadLine());
    }
    DateTime validCuots = new DateTime( 2023,mesFecha,dia);
    return cuotas;
}
List<DateTime> obtenerFechasPago(int cuotas, DateTime fecha)
{
    List <DateTime> fechas = new List<DateTime> ();
    for (int i = 0; i < cuotas; i++)
    {
        fechas.Add(fecha);
       fecha = fecha.AddMonths(1);
    }
    return fechas;
}
}
void punto3(){
//3
string[] meses = {"A", "enero", "febrero" , "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre","noviembre","diciembre"};
int dia = 0;
int mes = 0;
int dia2 = 0;
int mes2 = 0;


mes = elegirMes1(mes, ref dia);
DateTime fecha1 = new DateTime(2023,mes,dia);

mes2 = elegirMes2(dia,ref dia2,mes,mes2);
DateTime fecha2 = new DateTime(2023,mes2,dia2);

for (int i = mes; i <= mes2; i++)
{
    System.Console.WriteLine(meses[i]);
}

int elegirMes1(int mes, ref int dia)
{
System.Console.WriteLine("deci un dia");
dia = int.Parse(Console.ReadLine());
while (dia <=0)
{
    System.Console.WriteLine("Dia no encontrado, volve a ingresarlo!!");
    dia = int.Parse(Console.ReadLine());
}
System.Console.WriteLine("deci un mes");
mes = int.Parse(Console.ReadLine());
while(mes<=0 || mes >= 13)
{
    System.Console.WriteLine("Mes no encontrado, volve a ingresarlo!!");
    mes = int.Parse(Console.ReadLine());
}
return mes;
}

int elegirMes2(int dia, ref int dia2, int mes, int mes2)
{
System.Console.WriteLine("deci otro dia");
dia2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("deci otro mes");
while(mes2 <= mes){
mes2 = int.Parse(Console.ReadLine());
}
return mes2;
}
}
void punto4()
{
    int [] final = new int[5];
    int numeros = -1;
    int sumaDeNumeros = 0;
    while (numeros != 0 )
    {
         System.Console.WriteLine("Ingrese un numero: ");
        numeros = int.Parse(Console.ReadLine());
        if (numeros != 0)
        {
            if (numeros > final[0])
        {
         final[0] = numeros;
        }
        if (numeros < final[1])
        {
           final[1] = numeros;
        }
            final[2] = final[2] + numeros;
            sumaDeNumeros ++;

            
        }
    }
    final[3] = final[2] / sumaDeNumeros;
    final[4] = sumaDeNumeros;
     System.Console.WriteLine("El numero mayor es: " + final[0] + " El numero menor es: " + final[1]+ "La suma de sus valores seria: " + final[2]+ " El promedio es: " + final[3]+ " La cantidad de elementos es: " + final[4]);
}