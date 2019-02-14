using System;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia {
    public class Estagiario : Funcionario {
        public Estagiario (string CPF) : base (10, CPF) {

        }
        public override void AumentarSalario () {
            Console.WriteLine ("Danilo");
        }

        protected override double GetBonificacao () {
            return Salario * 0.17;
        }

    }
}