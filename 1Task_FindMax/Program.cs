int a1 = 43;
int b1 = 176;
int c1 = 26;
int a2 = 81;
int b2 = 78;
int c2 = 76;
int a3 = 33;
int b3 = 44;
int c3 = 67;

int max = a1;

if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);


