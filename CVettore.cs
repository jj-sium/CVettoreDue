using System;
using System.Linq;

public class Vettore 
{
    private int[] vettore;
    private int idx = 0;

    public Vettore () {
        vettore = new int[] { 0 };
    }

    public Vettore (int N)
    {
        if(N <=0 )
            vettore = new int[0];
        else
            vettore = new int[N];
    }

    public bool Aggiungi(int val)
    {
        if (idx >= vettore.Length)
            return false;

        vettore[idx] = val;
        idx++;
        return true;
    }

    //un metodo somma che torna la somma degli elementi
    public int Somma()
    {
        int retval = 0;

        for (int idx = 0; idx < vettore.Length; idx++)
            retval += vettore[idx];

        return retval;
    }

    //metodo ultimo
    public int Ultimo()
    {
        if( vettore.Length == 0)
            return 0;
        if (idx == 0)
            return vettore[idx];
        
        return vettore[idx-1];
    }

    public bool EliminaUltimo()
    {
        if( vettore.Length == 0 )
        {
            return false;
        }
        if (idx == 0)
        {
            if(vettore[idx] == 0)
                return false;
        }
        else
            vettore[idx - 1] = 0;
            return true;
    }
}