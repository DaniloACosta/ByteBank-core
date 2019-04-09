using System;

namespace ByteBank.SistemaInterno {
    public class Lista<T> {
        private T[] _array = null;
        private int _index;

        public int getSizeArray {
            get {
                return _index;
            }
        }

        public Lista (int indexInitial = 5) {
            // Console.WriteLine ($"Criando um ListaDeT{_index}");
            _array = new T[indexInitial];
            _index = 0;
            // Console.WriteLine ($"Criando um ListaDeT {_index}");
        }

        public T this [int index] {
            get {
                return getItemIndex (index);
            }
        }

        private T getItemIndex (int index) {
            if (index < 0 || index > _index) {
                throw new ArgumentOutOfRangeException (nameof (index));
            }

            return _array[index];
        }

        public void Add (T account) {
            CheckSizeArray ();
            _array[_index] = account;
            // Console.WriteLine ($"Criado um conta na posição {_index}");
            _index++;
        }

        public void AddAll (params T[] accounts) {
            foreach (var account in accounts) {
                Add (account);
            }
        }

        public void Remove (T accountRemove) {
            int _indexItem = -1;

            for (int i = 0; i < _index; i++) {
                if (accountRemove.Equals (_array[i])) {
                    _indexItem = i;
                    break;
                }
            }

            for (int i = _indexItem; i < _index - 1; i++) {
                _array[i] = _array[i + 1];
            }

            _index--;
        }

        public void Print () {
            for (int i = 0; i < _index; i++) {
                System.Console.WriteLine ($"Conta correte indice: {i} - Conta: {_array[i].ToString()}");
            }
        }

        private void CheckSizeArray () {
            if (_index < _array.Length) {
                return;
            }
            T[] newArray = new T[_index * 2];
            Array.Copy (sourceArray: _array, destinationArray: newArray, length: _array.Length);
            _array = newArray;
        }
        public int getIndexSize () {
            return _array.Length;
        }
    }
}