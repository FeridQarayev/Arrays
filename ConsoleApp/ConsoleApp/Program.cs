

int[] ints = new int[] { 1, 2, 3, 4 };
Console.WriteLine("before");
for (int i = 0; i < ints.Length; i++)   //// O(N) — Linear Complexity
{
    Console.Write(ints[i] + ", ");
}

Console.WriteLine("\n\nafter");
for (int i = 0; i < ints.Length; i++)   //// O(N) — Linear Complexity
{
    ints[i] = ints[i] + 1;
    Console.Write(ints[i] + ", ");
}