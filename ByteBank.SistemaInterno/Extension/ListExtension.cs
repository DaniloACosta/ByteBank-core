using System.Collections.Generic;

namespace ByteBank.SistemaInterno.Extension
{
    public static class ListExtension
    {
        public static void AddAll(this List<int> list, params int[] itens){
            foreach (var item in itens)
            {
                list.Add(item);
            }
        }
    }
}