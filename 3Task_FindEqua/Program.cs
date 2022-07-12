int [] array = {1, 23, 31, 45, 54, 65, 14, 45};

int n = array.Length;
int find = 45;

int index = 0;

while (index < n)
{
    if(array [index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}