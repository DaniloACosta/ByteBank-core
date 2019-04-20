using System.Collections;
using System.Collections.Generic;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia.Comparators
{
    public class ComparatorsContaCorrenteByAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if(x == y){
                return 0;
            }

            if(x == null){
                return 1;
            }

            if(y == null){
                return -1;
            }

            return y.Numero.CompareTo(x.Numero);
        }
    }
}