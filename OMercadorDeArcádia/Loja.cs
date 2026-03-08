using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OMercadorDeArcádia
{
    public class Loja
    {

        List<ItemMagico> itens = new List<ItemMagico>();

        public void AdicionarItem(ItemMagico itemNovo)
        {
            itens.Add(itemNovo);
        }
        
        public void RemoverItem(int id)
        {
            ItemMagico item = itens.Find(i => i.GetId() == id);

            if (item != null)
            {
                itens.Remove(item);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Item {item.GetNome()} removido da lista!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Erro! Item não encontrado!!");
                Console.ResetColor();
            }


        }

        public void Listar()
        {
            foreach(ItemMagico i in itens)
            {
                
                Console.WriteLine($"-ID:{i.GetId()}  |NOME: {i.GetNome()}");

                if (i.GetRaridade() == Raridade.Comum)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"RARIDADE: {i.GetRaridade()}");
                }
                else if(i.GetRaridade() == Raridade.Raro)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"RARIDADE: {i.GetRaridade()}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"RARIDADE: {i.GetRaridade()}");
                    
                }

                Console.ResetColor();
                Console.WriteLine($"{i.ToString()}");
                Console.WriteLine($"PREÇO FINAL: {i.CalcularPrecoFinal():c2}\n");
                
            }

        }
        public void ExibirMenu()
        {
            Console.WriteLine($"-------MENU-------");
            Console.WriteLine($"0- Sair");
            Console.WriteLine($"1- Cadastrar");
            Console.WriteLine($"2- Listar");
            Console.WriteLine($"3- Vender");
            Console.WriteLine($"4- Remover");
            Console.WriteLine($"------------------");

        }

        public void Vender(int id)
        {
            ItemMagico item = itens.Find(i => i.GetId() == id);

            if (item != null)
            {
                double precoFinal = item.CalcularPrecoFinal();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Item vendido: {item.GetNome()}");
                Console.WriteLine($"Preço final: {precoFinal:C2}");
                Console.ResetColor();

                itens.Remove(item);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro! Item não encontrado.");
                Console.ResetColor();
            }
        }
       


    }
}
