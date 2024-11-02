// Time: O(n)
// Space: 0(1)

int * removeEven(int * & arr, int &size) {
    int num = 0;
    for(int i = 0; i < size; i++)
    {
        if(arr[i] % 2 != 0) arr[num++] = arr[i];
    }
    size = num;
    return arr;
}