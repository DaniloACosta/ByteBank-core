using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaInterno {
    public class ListaDeContaCorrente {
        private ContaCorrente[] _arrayContaCorrente = null;
        private int _index;

        public ListaDeContaCorrente (int indexInitial = 5) {
            Console.WriteLine($"Criando um ListaDeContaCorrente{_index}");
            _arrayContaCorrente = new ContaCorrente[indexInitial];
            _index = 0;
            Console.WriteLine($"Criando um ListaDeContaCorrente {_index}");
        }

        public void Adicionar (ContaCorrente account) {
            CheckSizeArray ();
            _arrayContaCorrente[_index] = account;
            Console.WriteLine($"Criado um conta na posição {_index}");
            _index++;
        }

        private void CheckSizeArray () {
            if(_index < _arrayContaCorrente.Length){
                return;
            }
            ContaCorrente[] newArray = new ContaCorrente[_index * 2];
            Array.Copy(sourceArray: _arrayContaCorrente, destinationArray: newArray, length: _arrayContaCorrente.Length);
            _arrayContaCorrente = newArray;
        }
        public int getIndexSize(){
            return _arrayContaCorrente.Length;
        }

    }
}