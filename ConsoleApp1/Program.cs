﻿int a = 0, b = 0;

a = Convert.ToInt32(Console.ReadLine());

b = Convert.ToInt32(Console.ReadLine());

if ((a == b) || (a < 0))

{

    a = 5;

    b = 2 * a + b;

}

else

{

    a = b - a;

    b = 3 * a;

}

Console.WriteLine(b + a);