int[] board = new int[9];
string turn = "X";

for (int i = 0; i < 9; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine();
    }

    Console.Write(board[i] + " ");
}

while (true)
{
    Console.WriteLine("Jogador {0}, faça sua jogada: ", turn);
    int move = int.Parse(Console.ReadLine());

    if (board[move] != 0)
    {
        Console.WriteLine("Jogada inválida!");
        continue;
    }

    board[move] = turn == "X" ? 1 : 2;

    for (int i = 0; i < 9; i++)
    {
        if (i % 3 == 0)
        {
            Console.WriteLine();
        }

        Console.Write(board[i] + " ");
    }

    if (checkWinner(board))
    {
        break;
    }

    turn = turn == "X" ? "O" : "X";
}

if (turn == "X")
{
    Console.WriteLine("O jogador X venceu!");
}
else
{
    Console.WriteLine("O jogador O venceu!");
}

bool checkWinner(int[] board)
{
    for (int i = 0; i < 3; i++)
    {
        if (board[3 * i] == board[3 * i + 1] && board[3 * i] == board[3 * i + 2] && board[3 * i] != 0)
        {
            return true;
        }

        if (board[i] == board[i + 3] && board[i] == board[i + 6] && board[i] != 0)
        {
            return true;
        }
    }

    if (board[0] == board[4] && board[0] == board[8] && board[0] != 0)
    {
        return true;
    }

    if (board[2] == board[4] && board[2] == board[6] && board[2] != 0)
    {
        return true;
    }

    return false;
}
