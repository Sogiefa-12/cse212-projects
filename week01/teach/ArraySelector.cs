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
    var result = new List<int>();
    for (int i = 0; i < select.Length; i++)
    {
        switch (select[i])
        {
            case 1:
                if (i < list1.Length)
                {
                    result.Add(list1[i]);
                }
                break;
            case 2:
                if (i < list2.Length)
                {
                    result.Add(list2[i]);
                }
                break;
            default:
                throw new ArgumentException("Invalid value in selector array");
        }
    }
    return result.ToArray();
    }
}