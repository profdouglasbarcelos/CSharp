namespace Aula1005_POO
{
    class Cliente
    {
        // Atributo
        private string nome;

        // Propriedades
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


        // Construtores
        public Cliente() // Construtor vazio
        {

        }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}
