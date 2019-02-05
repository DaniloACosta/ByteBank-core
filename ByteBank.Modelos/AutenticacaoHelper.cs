namespace ByteBank.Modelos
{
    internal class AutenticacaoHelper
    {
        public bool Autenticar(string senha, string senhaTentativa)
        {
            return senha == senhaTentativa;
        }
    }
}