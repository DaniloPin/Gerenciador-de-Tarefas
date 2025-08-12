var gerenciador = new GerenciadorDeTarefas();

while (true)
{
    Console.WriteLine("\n=== Menu de Tarefas ===");
    Console.WriteLine("1 - Adicionar tarefa");
    Console.WriteLine("2 - Listar tarefas");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    if (opcao == "0")
    {
        Console.WriteLine("Saindo...");
        break;
    }

    switch (opcao)
    {
        case "1":
            Console.Write("Digite a descrição da tarefa: ");
            string descricao = Console.ReadLine();

            Tarefa tarefa = new Tarefa {
                Id = gerenciador.ListaDeTarefas.Count + 1,
                Descricao = descricao,
                DataCriacao = DateTime.Now,
                Status = "Pendente"
            };

            gerenciador.AdicionarTarefa(tarefa);
            Console.WriteLine("Tarefa adicionada!");
            break;

        case "2":
            gerenciador.ListarTarefas();
            break;

        default:
            Console.WriteLine("\nOpção inválida, tente novamente.");
            break;
    }
}