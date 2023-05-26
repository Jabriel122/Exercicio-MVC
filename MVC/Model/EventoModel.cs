using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_MVC.MVC.Model
{
    public class EventoModel
    {
        public string Nome {get; set;}

        public string Discricao {get; set;}

        public int DateTime {get; set;}

        public const string PATH = "Database/Eventos";


        public EventoModel()
        {
            string pasta = PATH.Split("/")[0];

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        } 
        
        public List<EventoModel> Ler()
        {
            List<EventoModel> eventos = new List<EventoModel>();

            string[] linha = File.ReadAllLines(PATH);

            foreach (var p1 in linha)
            {
                string[] atributos = p1.Split(";");
                EventoModel p = new EventoModel();

                p.Nome = atributos[0];
                p.Discricao = atributos[1];
                p.DateTime = int.Parse(atributos[2]);
                
                eventos.Add(p);
            }

            return eventos;
        }

        public string PreparaLinhaCSV(EventoModel p)
        {
            return $"{p.Nome}; {p.Discricao}; {p.DateTime}";
        }

        public void inserir (EventoModel p)
        {
            string[] linha = {PreparaLinhaCSV(p)};

            File.AppendAllLines(PATH, linha);


        }

    }
}