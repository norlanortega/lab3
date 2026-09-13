using System;
namespace JuegoCraps;

    public class Craps
{
	private Random numerosALea = new Random();

	private enum NombreDados
	{
		DOS_UNO = 2,
		TRES = 3,
		SIETE = 7,
		ONCE = 11,
		DOCE = 12
	}
	private enum Estado 
	{
		CONTINUA,
        GANA,
        PIERDE
    }
	public void jugar() 
	{
		Estado estadojuego = Estado.CONTINUA;
        int miPunto = 0;
		int sumaDeDados = tirarDados();

		switch ((NombreDados)sumaDeDados) 
		{
            case NombreDados.SIETE:
            case NombreDados.ONCE:
                estadojuego = Estado.GANA;
                break;
            case NombreDados.DOS_UNO:
            case NombreDados.TRES:
            case NombreDados.DOCE:
                estadojuego = Estado.PIERDE;
                break;
            default:
                estadojuego = Estado.CONTINUA;
                miPunto = sumaDeDados;
                Console.WriteLine($"El punto es {miPunto}");
                break;
        }


        while (estadojuego == Estado.CONTINUA)
        {
            sumaDeDados = tirarDados();
            if (sumaDeDados == miPunto)
            {
                estadojuego = Estado.GANA;
            }
            else if (sumaDeDados == (int)NombreDados.SIETE)
            {
                estadojuego = Estado.PIERDE;
            }
        }
        if (estadojuego == Estado.GANA)
        {
            Console.WriteLine("Jugador gana");
        }
        else
        {
            Console.WriteLine("Jugador pierde");
        }
    }

    public int tirarDados()
    {
        int dado1 = numerosALea.Next(1, 7);
        int dado2 = numerosALea(1, 7);
        int suma = dado1 + dado2;
        Console.WriteLine($"Jugador tiro {dado1} + {dado2} = {suma}");
        return suma;
    }
}
