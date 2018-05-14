namespace Aula1105_POO
{
    class Aluno : Pessoa
    {

        public string Matricula { get; set; }

        // Construtores

        public Aluno()
        {

        }

        public Aluno(string nome) : base(nome)
        {
            
        }

        public Aluno(string nome, string cpf) : base(nome, cpf)
        {
                        
        }

        public override string ShowInfoPessoa()
        {
            return "Aluno: " + Nome + ", Cpf: " + Cpf + ", Matricula: " + Matricula;
        }
    }
}
