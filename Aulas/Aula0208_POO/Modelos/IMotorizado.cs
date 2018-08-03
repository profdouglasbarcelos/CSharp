namespace Aula0208_POO.Modelos
{
    interface IMotorizado
    {
        int Velocidade { get; set; }
        void Acelerar();
        void Frenar();
    }
}
