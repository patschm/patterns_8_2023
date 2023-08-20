namespace Strategy;

internal class QuickSort : IStrategy
{
    public void Sort(int?[] array)
    {
        var last = array.Where(x=>x.HasValue).Count()-1;
        Sort(array, 0, last);
    }
    private int Partition(int?[] data, int left, int right)
    {
        var pivot = data[right];
        int i = left;
        int? temp;
        for (int j = left; j < right; ++j)
        {
            if (data[j] <= pivot)
            {
                temp = data[j];
                data[j] = data[i];
                data[i] = temp;
                i++;
            }
        }
        data[right] = data[i];
        data[i] = pivot;
        return i;
    }
    private void Sort(int?[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);
            if (pivot > 1)
            {
                Sort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                Sort(arr, pivot + 1, right);
            }
        }
    }
}
