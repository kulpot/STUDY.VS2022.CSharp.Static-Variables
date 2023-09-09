using System;

//ref link:https://www.youtube.com/watch?v=53LWUQVyZb8&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=45
//static - shared(VB) - means shares data, has its onw static memory area besides the stack and heap

class Cow
{
    //static int numInstances;
    public static int numInstances;
    int id;
    public Cow()
    {
        id = ++numInstances;
    }
}

class MainClass
{
    static void Main()
    {
        Cow.numInstances = 123;

        Cow betsy = new Cow();
        Cow georgy = new Cow();
    }
}