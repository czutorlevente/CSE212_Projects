public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int index_1 = 0;
        int index_2 = 0;
        List<int> l3 = new List<int>();
        foreach (int number in select)
        {
            if (number == 1)
            {
                l3.Add(list1[index_1]);
                index_1 = index_1 + 1;
            }

            else if (number == 2)
            {
                l3.Add(list2[index_2]);
                index_2 = index_2 + 1;
            }
        }

        int[] a3 = l3.ToArray();
        return a3;
    }
}