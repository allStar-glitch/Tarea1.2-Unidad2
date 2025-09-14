using System;

public class Circulo
{
    private double radio;

    public Circulo()
    {
        radio = 1.0;
    }

    public Circulo(double radio)
    {
        if (radio > 0)
        {
            this.radio = radio;
        }
        else
        {
            Console.WriteLine("Error: el radio es invalido, se te asigan un radio por defecto(1.0).");
        }

    }

    public double CalcularArea()
    {
        return Math.PI * (radio * radio);

    }

    public double CalcularCircunferencia()
    {
        return 2 * Math.PI * radio;

    }

}
