using NaveEspacial;
using System.Drawing;

Ventana ventana;
Nave nave;
bool jugar = true;
void Inicar()
{
    ventana = new Ventana(170, 45, ConsoleColor.Black, new Point(5, 3), new Point(165, 43));
    ventana.DibujarMarco();
    nave = new Nave(new Point(80, 30), ConsoleColor.White, ventana);
    nave.Dibujar();
}
void Game()
{
    while (jugar)
    {
        nave.Mover(2);
        nave.Disparar();
        if (nave.Vida <= 0)
        {
            jugar = false;
            nave.Muerte();
        }
    }
}

Inicar();
Game();
Console.ReadKey();
