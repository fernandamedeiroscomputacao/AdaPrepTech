//using AdaPrepTech.DataStrutures.Lists;

////SingleLinkedList singleLinkedList = new SingleLinkedList();
////Console.WriteLine("SingleLinkedList");
////singleLinkedList.Test();

////DoubleLinkedList doubleLinkedList = new DoubleLinkedList();
////Console.WriteLine("DoubleLinkedList");
////doubleLinkedList.Test();

//CircularDoubleLinkedList circularDoubleLinkedList = new CircularDoubleLinkedList();
//Console.WriteLine("CircularDoubleLinkedList");
//circularDoubleLinkedList.Test();


int Pow(int x, int n)
{
    // Caso base: x^0 = 1
    if (n == 0)
        return 1;

    // Caso base: x^1 = x
    if (n == 1)
        return x;

    // Se n é par, utiliza a propriedade (x^n) = (x^(n/2))^2
    if (n % 2 == 0)
        return Pow(x * x, n / 2);
    else // Se n é ímpar, utiliza a propriedade (x^n) = x * (x^(n-1))
        return x * Pow(x, n - 1);
}


Console.WriteLine(Pow(20, 10)); 
