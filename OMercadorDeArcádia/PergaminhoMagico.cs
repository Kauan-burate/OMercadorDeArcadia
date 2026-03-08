using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMercadorDeArcádia
{
    public class PergaminhoMagico : ItemMagico
    {
        private string tipoEfeito;
        public PergaminhoMagico() { }
        public PergaminhoMagico(string nome, double preco, Raridade raridade, string tipoEfeito) : base( nome, preco, raridade) 
        {
            SetTipoEfeito(tipoEfeito);
        }
        public void SetTipoEfeito(string tipoEfeito) { this.tipoEfeito = tipoEfeito;}
        public string GetTipoEfeito() { return this.tipoEfeito; }

        public override string ToString()
        {
            return ($"EFEITO: {GetTipoEfeito()}");
        }
    }
}
