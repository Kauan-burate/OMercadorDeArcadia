using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMercadorDeArcádia
{

    public enum Raridade
    {
        Comum = 1,
        Raro = 2,
        Epico = 3
    }
    public class ItemMagico
    {
        private static int contador = 1;

        private string nome;
        private double preco;
        private Raridade raridadeItem;
        private int id;
       

        public ItemMagico() { }
        public ItemMagico(string nome, double preco, Raridade raridade)
        {
            this.id = contador++;
            SetNome(nome);
            SetPreco(preco);
            SetRaridade(raridade);
        }
        public void SetNome(string nome) { this.nome = nome; }
        public void SetPreco(double preco) 
        { 
            if(preco > 0)
            {
                this.preco = preco;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Erro número invalido!");
            }
            
        }
        public void SetRaridade(Raridade raridade) { this.raridadeItem = (Raridade)raridade; }
        public Raridade GetRaridade() { return this.raridadeItem; }
        public double GetPreco() { return this.preco; }
        public string GetNome() { return this.nome; }
        public int GetId() { return this.id; }

        public virtual double CalcularPrecoFinal() 
        {
            return GetPreco();
        }
       

    }
}
