using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMercadorDeArcádia
{
    public class ArmaMagica : ItemMagico
    {
        private double dano;

        public ArmaMagica() { }
        public ArmaMagica(string nome, double preco, Raridade raridade, double dano) : base(nome, preco, raridade)
        {
            SetDano(dano);
        } 
        public void SetDano(double dano) { this.dano = dano;}
        public double GetDano() { return this.dano;}

        public override double CalcularPrecoFinal()
        {
            return GetPreco() * 1.05;
        }

        public override string ToString()
        {
            return ($"DANO: {GetDano()}");
        }

    }
}
