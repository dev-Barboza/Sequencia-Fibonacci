using System;

class Recursividade
{
    public void GerarSequecia(int numero1, int numero2, int vezes)
    {
       if(vezes>= 0 )
       {
           
           Console.WriteLine(numero1);
           GerarSequecia(numero2,numero1 + numero2 , vezes -1 );


       }
    }

    public int GerarSequeciaFac(int numero)
    {
        if(numero == 1){
            return 1;
        }else{
            return numero * GerarSequeciaFac( numero -1);
        }
        
    }

    
}