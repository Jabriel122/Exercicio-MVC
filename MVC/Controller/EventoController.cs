using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_MVC.MVC.Model;
using Exercicio_MVC.MVC.View;

namespace Exercicio_MVC.MVC.Controller
{
    public class EventoController
    {
        EventoModel eventoModel = new EventoModel();
        EventoViewer eventoViewer = new EventoViewer();

        public void ListarEventos()
        {
            List<EventoModel> eventoModels = eventoModel.Ler();
            eventoViewer.Listar(eventoModels);
        }

        public void Cadastrar()
        {
            EventoModel novo = eventoViewer.Cadastrar();
            eventoModel.inserir(novo);
        }


    }
}