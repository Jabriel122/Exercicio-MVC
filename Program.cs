// Exercício de fixação 

// Criar um programa console Para cadastro de Eventos. Aplique os conceitos MVC aprendidos em sala de aula.

// O evento deve ter Nome, Descrição e Data que o evento ocorrerá.

// As funcionalidades devem ser Cadastrar e Listar.

// Sugestão: Criar a estrutura do zero, ao invés de copiar e colar, pois assim você fixará os conceitos.


using Exercicio_MVC.MVC.Controller;
using Exercicio_MVC.MVC.Model;

EventoModel p = new EventoModel();
EventoController controller = new EventoController();

controller.Cadastrar();
controller.ListarEventos();