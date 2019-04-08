using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaInterno {
    public class ListaDeContaCorrente {
        private ContaCorrente[] _arrayContaCorrente = null;
        private int _index;

        public int getSizeArray {
            get {
                return _index;
            }
        }

        public ListaDeContaCorrente (int indexInitial = 5) {
            // Console.WriteLine ($"Criando um ListaDeContaCorrente{_index}");
            _arrayContaCorrente = new ContaCorrente[indexInitial];
            _index = 0;
            // Console.WriteLine ($"Criando um ListaDeContaCorrente {_index}");
        }

        public ContaCorrente this [int index] {
            get {
                return getItemIndex (index);
            }
        }

        private ContaCorrente getItemIndex (int index) {
            if (index < 0 || index > _index) {
                throw new ArgumentOutOfRangeException (nameof (index));
            }

            return _arrayContaCorrente[index];
        }

        public void Add (ContaCorrente account) {
            CheckSizeArray ();
            _arrayContaCorrente[_index] = account;
            // Console.WriteLine ($"Criado um conta na posição {_index}");
            _index++;
        }

        public void AddAll(params ContaCorrente[] accounts)
        {
            foreach (var account in accounts)
            {
                Add(account);
            }
        }

        public void Remove (ContaCorrente accountRemove) {
            int _indexItem = -1;

            for (int i = 0; i < _index; i++) {
                if (accountRemove.Equals (_arrayContaCorrente[i])) {
                    _indexItem = i;
                    break;
                }
            }

            for (int i = _indexItem; i < _index - 1; i++) {
                _arrayContaCorrente[i] = _arrayContaCorrente[i + 1];
            }

            _index--;
            _arrayContaCorrente[_index] = null;
        }

        public void PrintContaCorrente () {
            for (int i = 0; i < _index; i++) {
                System.Console.WriteLine ($"Conta correte indice: {i} - Conta: {_arrayContaCorrente[i].Agencia} Numero: {_arrayContaCorrente[i].Numero}");
            }
        }

        private void CheckSizeArray () {
            if (_index < _arrayContaCorrente.Length) {
                return;
            }
            ContaCorrente[] newArray = new ContaCorrente[_index * 2];
            Array.Copy (sourceArray: _arrayContaCorrente, destinationArray: newArray, length: _arrayContaCorrente.Length);
            _arrayContaCorrente = newArray;
        }
        public int getIndexSize () {
            return _arrayContaCorrente.Length;
        }

    }
}