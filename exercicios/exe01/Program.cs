int[] vetor = {-5, 13, -90, 99, 326, -34, 67, -81, 777, 0};
Array.Sort(vetor);
foreach (int i in vetor)
{
    Console.WriteLine("Ordenando...");
    Console.WriteLine(i);
}
Array.Sort(vetor);
foreach (int i in vetor)
{
    Console.WriteLine(i);
}