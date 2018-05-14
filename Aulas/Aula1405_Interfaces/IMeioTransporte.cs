namespace Aula1405_Interfaces
{
    interface IMeioTransporte
    {
        int Velocidade { get; set; }
        void Acelerar();
        void Desacelerar();

        string ImprimirInfo();
    }
}
