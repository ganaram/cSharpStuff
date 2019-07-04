using System;

    public class EjemploTryCatchParse{

       public static void Main(){
           int manolo = 0;
           do{
            Console.WriteLine("Introduce algo shur");
           try{
            
               string aux = Console.ReadLine();
            
            if(int.TryParse(aux,out manolo))
                 Console.WriteLine(manolo + " Es un entero.");
            else 
                Console.WriteLine("No es un número, zopenco.");
           }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
           
           }while(manolo<10);
       }

      }