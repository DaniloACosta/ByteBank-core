using System;

namespace ByteBank.SistemaInterno{

    class ExtratorValorDeArgumentosURL{
        
        private readonly string _argumento;
        public string URL { get; } 

        public ExtratorValorDeArgumentosURL(string url)
        {
            if(String.IsNullOrEmpty(url)){
                throw new ArgumentException("O argumento url não pode ser null ou vazia", nameof(url));
            }

            URL = url;
            int indeceInterrogação = url.IndexOf('?');
            _argumento = url.Substring(indeceInterrogação + 1);

        }

        public string getValor(string nomeParametro){

            int indice = _argumento.IndexOf(nomeParametro);
            int indiceValor = indice + nomeParametro.Length;
            return _argumento.Substring(indiceValor + 1);
        }

    }
}