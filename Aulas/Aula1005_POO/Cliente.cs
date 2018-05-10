namespace Aula1005_POO
{
    class Cliente
    {
        // Atributo
        private string nome;

        // Propriedade
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }


        public string Cpf { get; set; }

    }
}
