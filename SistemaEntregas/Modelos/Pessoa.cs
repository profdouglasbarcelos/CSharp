namespace Modelos
{
    public abstract class Pessoa
    {
        public int PessoaID { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public int EnderecoID { get; set; }

        public Endereco _Endereco { get; set; }
    }
}
