using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATELASCIATE_AL_CASO
{
    internal class Program
    {
        static void Main(string[] args)
        {
              int N;
              N =10000;
     
             int[] coincidenze = new int[N];
            int c;
           float Contapro;
            using (StreamWriter sw = new StreamWriter("c:\\Users\\Francesco\\Desktop\\F.xslm"))
            {

                Random random = new Random();
            int nP;
    for( nP = 0; nP<366; nP++)
            {
                Contapro = 0;
                nP++;
            

            int[] Persone = new int[nP];
           for (int b = 0; b <coincidenze.Length; b++){
                c = 0;
                for (int i = 0; i <Persone.Length; i++)
                {
                   
                   Persone[i] = random.Next(1, 366);
                }
               for (int i=0; i<Persone.Length; i++) { 
            
               for(int k=i+1;k<Persone.Length;k++)
                {
                 if (Persone[i] == Persone[k])
                    {
                     c++;
                  }
                
                }
               
                }
                if (c>0)
                {
                coincidenze[b]=1 ;
                Contapro++;
                }
            }
            
            Console.WriteLine("{0}persone-> probabilita:{1}", nP,(Contapro/N)*100);
             sw.WriteLine($"{nP};numero persone;probabilita; {(Contapro / N) * 100}%;");
            }
            }
            Console.ReadLine();

        }
       
    }

}
