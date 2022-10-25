// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

p21();
//fct de grad 1
static void p1()
{
    string s = Console.ReadLine();
    string[] t = s.Split(' ');
    float a=int.Parse(t[0]);
    float b=int.Parse(t[1]);
    float x = - b / a;
    Console.Write(x);
}
//fct de grad 2
static void p2()
{
    string s = Console.ReadLine();
    string[] t = s.Split(' ');
    double a = int.Parse(t[0]);
    double b = int.Parse(t[1]);
    double c = int.Parse(t[2]);
    double x;
    if(b*b-4*a*c > 0)
    {
        x = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
        Console.WriteLine("x1 = " + x);
        x = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
        Console.WriteLine("x2 = " + x);
    }
    else
    {
        if (-b % 2 * a == 0 && Math.Sqrt((0 - (b * b - 4 * a * c))) % 2 * a == 0)
        {
            x = (-b / 2 * a);
            Console.WriteLine("x1 = " + x + " + i" + (Math.Sqrt((0 - (b * b - 4 * a * c))) / 2 * a));
            Console.WriteLine("x2 = " + x + " - i" + (Math.Sqrt((0 - (b * b - 4 * a * c))) / 2 * a));
        }
        else
        {
            Console.WriteLine("x1 = " + (-b) + "+ i" + (Math.Sqrt((0 - (b * b - 4 * a * c))) / 2 * a) + " / " + (2 * a));
            Console.WriteLine("x2 = " + (-b) + "- i" + (Math.Sqrt((0 - (b * b - 4 * a * c))) / 2 * a) + " / " + (2 * a));
        }
    }
}
//n divide k
static void p3()
{
    string s = Console.ReadLine();
    string[] t = s.Split(' ');
    int n = int.Parse(t[0]);
    int k = int.Parse(t[1]);
    if (k % n == 0)
    {
        Console.WriteLine(1);
    }
    else
    {
        Console.WriteLine(0);
    }
}
//an bisect
static void p4()
{
    int n = int.Parse(Console.ReadLine());
    if(n%4==0)
    {
        Console.WriteLine(n + " este an bisect.");
    }
    else
    {
        Console.WriteLine(n + " nu este an bisect.");
    }
}

static void p5()
{
    string s = Console.ReadLine();
    string[] t = s.Split(' ');
    int n = int.Parse(t[0]);
    int k = int.Parse(t[1]);
    int count = 0;
    while(n!=0)
    {
        int c = n % 10;
        count++;
        if(count==k)
        {
            Console.WriteLine(c);
            break;
        }
        n = n / 10;
    }
}

static void p6()
{
    string s = Console.ReadLine();
    string[] t = s.Split(' ');
    int a = int.Parse(t[0]);
    int b = int.Parse(t[1]);
    int c = int.Parse(t[2]);
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Numerele pot fi lungimile laturilor unui triunghi");
    }
    else
    {
        Console.WriteLine("no lol");
    }
}

static void p7()
{
    string s = Console.ReadLine();
    string[] t = s.Split(' ');
    int a = int.Parse(t[0]);
    int b = int.Parse(t[1]);
    int aux = a;
    a = b;
    b = aux;
    Console.WriteLine("a = " + a + " si b = " + b);
}

static void p8()
{
    string s = Console.ReadLine();
    string[] t = s.Split(' ');
    int a = int.Parse(t[0]);
    int b = int.Parse(t[1]);
    a = a + b;
    b = a - b;
    a = a - b;
    Console.WriteLine("a = " + a + " si b = " + b);
}

static void p9()
{
    int n = int.Parse(Console.ReadLine());
    for (int d = 2; d <= n / 2; d++)
    {
        if(d*d==n)
        {
            Console.Write(d + " ");
        }
        else if(n%d==0)
        {
            Console.Write(d + " ");
        }
    }
}

static void p10()
{
    int n = int.Parse(Console.ReadLine());
    bool ok = true;
    for(int d=2;d*d<=n;d++)
    {
        if(n%d==0)
        {
            ok = false;
            break;
        }
    }
    if(ok==true)
    {
        Console.WriteLine(1);
    }
    else
    {
        Console.WriteLine(0);
    }
}

static void p11()
{
    int n = int.Parse(Console.ReadLine());
    while(n>0)
    {
        Console.Write(n % 10);
        n = n / 10;
    }
}

static void p12()
{
    string s = Console.ReadLine();
    string[] t = s.Split(' ');
    int a = int.Parse(t[0]);
    int b = int.Parse(t[1]);
    int n = int.Parse(t[2]);
    int count = 0;
    for(int i=a;i<=b;i++)
    {
        if(n%i==0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

static void p13()
{
    string s = Console.ReadLine();
    string[] t = s.Split(' ');
    int y1 = int.Parse(t[0]);
    int y2 = int.Parse(t[1]);
    int count = 0;
    for(int i=y1;i<=y2;i++)
    {
        if(i%4==0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

static void p14()
{
    int n = int.Parse(Console.ReadLine());
    int m = n;
    int p = 10, s = 0;
    while (n > 0) 
    {
        int c = n % 10;
        s = s * p + c;
        n = n / 10;
    }
    if(s==m)
    {
        Console.WriteLine(1);
    }
    else
    {
        Console.WriteLine(0);
    }
}

static void p15()
{
    string s = Console.ReadLine();
    string[] t = s.Split(' ');
    int a = int.Parse(t[0]);
    int b = int.Parse(t[1]);
    int c = int.Parse(t[2]);
    if(a>b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }
    if(b>c)
    {
        b = b + c;
        c = b - c;
        b = b - c;
    }
    if(a>b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }
    Console.WriteLine(a + " " + b + " " + c);
}

static void p17()
{
    string s = Console.ReadLine();
    string[] t = s.Split(' ');
    int n = int.Parse(t[0]);
    int m = int.Parse(t[1]);
    int x = n; int y = m;
    while(m!=0)
    {
        int r = n % m;
        n = m;
        m = r;
    }
    Console.WriteLine("cmmdc este " + n);
    Console.WriteLine("cmmmc este" + x * y / n);
}

static void p18()
{
    int n = int.Parse(Console.ReadLine());
    int d = 2;
    while (n > 1) 
    {
        int p = 0;
        while (n % d == 0) 
        {
            p++;
            n = n / d;
        }
        if(p!=0)
        {
            Console.Write(d + " * " + p + " ");
        }
        d++;
        if (d * d > n && n > 1) 
        {
            d = n;
        }
    }
}

static void p19()
{
    int n = int.Parse(Console.ReadLine());
    int c1 = n % 10; int c3 = -1;
    int count = 0; bool ok = true;
    n = n / 10;
    while (n > 0) 
    {
        int c2 = n % 10;
        if (c1 != c2 && c2 != c3) 
        {
            c3 = c1;
            c1 = c2;
            count++;
        }
        if(count>1)
        {
            ok = false;
            break;
        }
        n = n / 10;
    }
    if(ok==true)
    {
        Console.WriteLine(1);
    }
    else
    {
        Console.WriteLine(0);
    }
}

static void p20()
{
    string s = Console.ReadLine();
    string[] t = s.Split(' ');
    int m = int.Parse(t[0]);
    int n= int.Parse(t[1]);
    // TODO aducem fractia la forma ireductibila. 
    int parteInt, parteFract;
    parteInt = m / n; // 0
    parteFract = m % n; // 13
    Console.Write($"{parteInt},");
    int cifra, rest;
    List<int> resturi = new List<int>();
    List<int> cifre = new List<int>();
    resturi.Add(parteFract);
    bool periodic = false;
    do
    {
        cifra = parteFract * 10 / n;
        cifre.Add(cifra);
        //Console.Write($"{cifra}");
        rest = parteFract * 10 % n;
        if (!resturi.Contains(rest))
        {
            resturi.Add(rest);
        }
        else
        {
            periodic = true;
            break;
        }
        parteFract = rest;
    } while (rest != 0);

    if (!periodic)
    {
        foreach (var item in cifre)
        {
            Console.Write(item);
        }
    }
    else
    {
        for (int i = 0; i < resturi.Count; i++)
        {
            if (resturi[i] == rest)
            {
                Console.Write("(");
            }
            Console.Write(cifre[i]);
        }
        Console.WriteLine(")");
    }
}
/// <summary>
/// Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
/// </summary>
static void p21()
{
    Random rnd = new Random();
    int n = rnd.Next(1, 1024);
    bool ok = true;
    while (ok == true)
    {
        int m = int.Parse(Console.ReadLine());
        if (m > n) 
        {
            Console.WriteLine("Numar este mai mic decat " + m);
        }
        else if(m < n)
        {
            Console.WriteLine("Numarul este mai mare decat " + m);
        }
        else if(m==n)
        {
            Console.WriteLine("in sfarsit"); 
            ok = false;
        }
    }
}
Console.ReadKey();