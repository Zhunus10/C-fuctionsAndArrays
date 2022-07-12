int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 43;
int b1 = 176;
int c1 = 26;
int a2 = 8659;
int b2 = 78;
int c2 = 76;
int a3 = 33;
int b3 = 4434;
int c3 = 67;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));
Console.WriteLine(max);