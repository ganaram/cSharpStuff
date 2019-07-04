using System;

    public class Telefoniyos{

        public static void Main(){

            Telefono tlf1 = new Telefono("encendido",true,675773101);
            Telefono tlf2 = new Telefono("encendido",true,693184106);

            Telefono.llamar(tlf1,tlf2);
        }

    }

    public enum Estado{
        apagado,
        encendido
    };

    public class Telefono{
        protected Estado estado;
        protected bool tieneLinea;
        protected int numero;

        public Telefono(string estadoValue, bool tieneLinea, int numero){
            estado =  ( Estado ) Enum.Parse(typeof( Estado), estadoValue);
            this.tieneLinea = tieneLinea;
            this.numero = numero;
        }

        public static void llamar(Telefono tlf1, Telefono tlf2){
         
            if(tlf1.numero!=tlf2.numero && tlf1.tieneLinea && tlf2.tieneLinea && estaEncendido(tlf1) && estaEncendido(tlf2)){
                Console.WriteLine("El teléfono con número: " + tlf1.numero + " al teléfono con número: " + tlf2.numero);
            }else Console.WriteLine("Alguno de los dispositivos está sin linea o apagado");

        }

        public int getNumero(){
            return numero;
        }

        public static string getEstado(Telefono tlf){
            string aux = tlf.estado.ToString();
            return aux;
        }

        public static bool estaEncendido(Telefono tlf){
            if(getEstado(tlf)!="encendido")
                return false;
            return true;
            
        }
    }