using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_MVC.MVC.Model;

namespace Exercicio_MVC.MVC.View
{
    public class EventoViewer
    {
        public void Listar(List<EventoModel> eventoModels)
        {
            Console.Clear();

            foreach (var p in eventoModels)
            {
                Console.WriteLine($"\nNome: {p.Nome}");
                Console.WriteLine($"Discrição: {p.Discricao}");
                Console.WriteLine($"Data: {p.DateTime}");
            }
        }
        public EventoModel Cadastrar()
        {
            EventoModel novo = new EventoModel();

            Console.WriteLine($"Informe o Nome:");
            novo.Nome = Console.ReadLine();
            
            Console.WriteLine($"Informe a Discrição:");
            novo.Discricao = Console.ReadLine();
            
            Console.WriteLine($"Informe a Data:");
            novo.DateTime = int.Parse(Console.ReadLine());
                        
            return novo;

        }
    }


}