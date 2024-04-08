
public static class Game
{


    public static void StartGame(Tree tree)
    {
        tree.Reset();

        Console.WriteLine("\nPense em um prato que gosta \n");

        MakeQuestion(tree);
    }

    public static void MakeQuestion(Tree tree)
    {
        Console.WriteLine(tree.Current.Text);
        tree.Next(AnswerIsTrue());

        if (tree.Current != null && tree.Current.IsLeaf == false)
        {
            MakeQuestion(tree);
        }
        else if (tree.Current != null)
        {
            MakeSuggestion(tree);
        }
    }

    public static void MakeSuggestion(Tree tree)
    {
        Console.WriteLine("\nO prato que vc pensou é: " + tree.Current.Text);

        if (AnswerIsTrue())
        {
            Console.Clear();
            Console.WriteLine("\nAcertei de novo! \n");
            StartGame(tree);
        }
        else
        {
            RegisterNewNode(tree);
        }
    }

    public static void RegisterNewNode(Tree tree)
    {
        var current = tree.Current;

        Console.WriteLine("\nQual prato vc pensou?");
        var answer = Console.ReadLine();

        Console.WriteLine("\n" + answer + " é ____ mas " + tree.Current.Text + " não");
        var condition = Console.ReadLine();

        var newNode = new Node("\nO prato que vc pensou é " + condition, false, current.Parent);
        newNode.LeftNode = current;

        // Adiciona o novo prato como resposta true da nova pergunta
        newNode.RightNode = new Node(answer, true, newNode);

        // Muda os nós de lugar
        if (current.Parent.RightNode == current)
        {
            current.Parent.RightNode = newNode;
        }
        else
        {
            current.Parent.LeftNode = newNode;
        }
        current.Parent = newNode;

        StartGame(tree);
    }

    public static bool AnswerIsTrue()
    {
        Console.WriteLine("1 - Sim / 2 - Nao");
        var answer = Console.ReadLine();

        var control = true;

        while (control)
        {
            if (answer != "1" && answer != "2")
            {
                Console.WriteLine("\nResposta inválida! Escolha uma das opções disponíveis no menu: '1' para Sim ou '2' para Não!");
                answer = Console.ReadLine();
                //Console.Clear();
            }
            else
                control = false;
        }
        Console.Clear();

        return answer == "1";
    }
}

