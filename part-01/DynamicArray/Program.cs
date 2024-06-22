namespace DynamicArray;

public class Program
{
    static void Main(string[] args)
    {
        var array = new DynamicArray<int>();

        array.PushBack(10);
        array.PushBack(20);
        array.PushBack(30);

        int posicaoInserir = 1;
        int valorInserir = 99;
        Console.WriteLine($"\nInserindo o valor {valorInserir} " +
            $"na posição {posicaoInserir}...");
        array.Insert(posicaoInserir, valorInserir);

        int valorBuscado = 20;
        int indiceEncontrado = array.Search(valorBuscado);
        Console.WriteLine($"O valor {valorBuscado} foi encontrado " +
            $"no índice {indiceEncontrado}");

        int posicaoRemover = 2;
        Console.WriteLine($"\nRemovendo o elemento na posição {posicaoRemover}...");
        array.RemoveAt(posicaoRemover);
    }
}
