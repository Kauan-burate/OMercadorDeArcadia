using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMercadorDeArcádia
{
    public class PocaoMagica : ItemMagico
    {
        private string efeito;
        public PocaoMagica() { }
        public PocaoMagica( string nome, double preco, Raridade raridade, string efeito) : base( nome, preco, raridade)
        {
            SetEfeito(efeito);
        }

        public void SetEfeito(string efeito) { this.efeito = efeito; }
        public string GetEfeito() { return this.efeito; }

        public override double CalcularPrecoFinal()
        {
            return GetPreco() * 0.90;
        }
        public override string ToString()
        {
            return ($"EFEITO: {GetEfeito()}");
        }

    }
}
