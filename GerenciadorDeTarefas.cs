class GerenciadorDeTarefas
{
    public List<Tarefa> ListaDeTarefas { get; set; }

    public GerenciadorDeTarefas()
    {
        ListaDeTarefas = new List<Tarefa>(); 
    }

    public void AdicionarTarefa(Tarefa novaTarefa) 
    {
        ListaDeTarefas.Add(novaTarefa);
    }

    public void ListarTarefas()
    {
        if (ListaDeTarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa encontrada.");
            return;
        }

        foreach (var tarefa in ListaDeTarefas)
        {
            Console.WriteLine($"\nId: {tarefa.Id}");
            Console.WriteLine($"Descrição: {tarefa.Descricao}");
            Console.WriteLine($"Status: {tarefa.Status}");
            Console.WriteLine("--------------------");
        }
    }
}
