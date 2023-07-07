//Herencia

Vehiculo vehiculo = new Vehiculo();
vehiculo.Arrancar();


Coche coche = new Coche();
coche.Arrancar();
coche.DetenerCoche();


//Clase Parent
class Vehiculo 
{
    public double gasolina { get; set; }
    public int aforo { get; set; }


    public void Arrancar()
    {
        Console.WriteLine("Este vehiculo ha arrancado");
    }
}

//Clase Child
class Coche : Vehiculo
{
    public int ruedas { get; set; }

    public void DetenerCoche()
    {
        Console.WriteLine("El coche se ha detenido");

    }
}
