namespace Aula1105_POO
{
    class Aluno
    {
        // Atributos
        private string nome;

        //Propriedades
        public string Nome
        {
            get => nome; // get { return nome; }
            set => nome = value; // set { nome = value; }
        }

        public string Cpf { get; set; }


        // Construtores

        public Aluno()
        {

        }
        
        public Aluno(string nome)
        {
            Nome = nome;
        }

        public Aluno(string nome, string cpf)
        {
            this.nome = nome;
            Cpf = cpf;
        }
    }
}
