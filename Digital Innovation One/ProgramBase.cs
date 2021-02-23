namespace Digital_Innovation_One
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Bini");

            Console.WriteLine(minhaConta.ToString());
        }

        private static string ObterOpcaoUsuario()
        {

        }
    }
}