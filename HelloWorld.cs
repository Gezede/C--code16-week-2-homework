using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
  
    void BolenleriBul(int sayi1, int sayi2)
 {



       
        for (int i = sayi1; i <= sayi2; i++) 
        {


            print(sayi1 + " 'den " + sayi2 + " 'ye kadar t�m liste :" + i);


        }

        
        for(int i=sayi1; i<=sayi2; i++)
        {



            if (i % 2 == 0)
            {
                print(sayi1 + " 'den " + sayi2 + " 'ye kadar 2'e b�l�nenler :" + i);
            }
        }

        

        
        for (int i = sayi1; i <= sayi2; i++)
        {

            if (i % 3 == 0)
            {
                print(sayi1 + " 'den " + sayi2 + " 'ye kadar 3'e b�l�nenler :" + i);
            }

        }

        
        for (int i = sayi1; i <= sayi2; i++)
        {

            if (i % 4 == 0)
            {
                print(sayi1 + " 'den " + sayi2 + " 'ye kadar 4'e b�l�nenler :" + i);
            }

        }

        
        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 5 == 0)
            {
              
                print(sayi1 + " 'den " + sayi2 + " 'ye kadar 5'e b�l�nenler : " + i );
            }
            
        }

        return;

    }




    
    void Start()
    {
    BolenleriBul(20, 44);
    }

   
}
    

       