using System;

namespace Sintaxis 
{
    class Program
    {

        // DECLARACION DE VARIABLES GLOBALES
        
        
        static int variableEntero1;
        static int variableEntero2 = 1;
        static int variableEntero3, variableEntero4;
        static int variableEntero5 = 10, variableEntero6 = 11;
        static int variableEntero7, variableEntero8 = 10;

        // TIPO DE DATOS PRIMITIVOS ¿INVESTIGAR QUE ES UN TIPO DE DATO PRIMITIVO? (VALUE TYPES)
        // Se llama tipo primitivo o tipo elemental a los tipos de datos originales de un lenguaje de programación
        // esto es, aquellos que nos proporciona el lenguaje y con los que podemos construir tipos de datos abstractos 
        // y estructuras de datos. Generalmente ejemplos de tipos primitivos son: Char Int Float
        static int vEntero;         // APLICA PARA DATOS DE TIPO ENTERO ¿INVESTIGAR CAPACIDADES DE UN INT?
        static double vDoueble;     // APLICA PARA DATOS DE TIPO DECIMAL ¿INVESTIGAR CAPACIDADES DE UN DOUEBLE?
        static decimal vDecimal;    // APLICA PARA DATOS DE TIPO DECIMAL ¿INVESTIGAR CAPACIDADES DE UN DECIMAL?
        static float vfloat;        // APLICA PARA DATOS DE TIPO DECIMAL ¿INVESTIGAR CAPACIDADES DE UN FLOAT?
        static string vString;      // APLICA PARA DATOS DE TIPO CADENA
        static bool vBool;          // APLICA PARA DATOS DE TIPO BOOLEANO (FALSO O VERDADERO)
        static DateTime vfecha;     // APLICA PARA DATOS DE TIPO FECHA; ¿INVESTIGAR SI ES TIPO DE DATO PRIMITIVO O TIPO DE DATO POR REFERENCIA?

        // TIPO DE DATOS DE REFERENCIA (REFERENCE TYPE)
        Object vObject;      // APLICA PARA OBJETOS EN GENERAL


        // ASI SE DECLARA EL METODO MAIN
        static void Main(string[] args)  // NO LLEVA ;
        {
            // DECLARACION DE VARIABLES LOCALES
            int vLocalEntero1;
            int vLocalEntero2 = 10;
            int vLocalEntero3, vLocalEntero4;
            int vLocalEntero5 = 10, vLocalEntero6;

            // PARA ACCEDER A UNA VARIABLE GLOBAL
            VEntero = 10;



            // OPERACIONES ARITMETICAS
            // SUMA
            vEntero = vEntero + 5;          // TERMINA EN ;
            // RESTAS
            vEntero = vEntero - 5;          // TERMINA EN ;
            // MULTIPLACIONES
            vEntero = vEntero * 5;          // TERMINA EN ;
            // DIVISIONES
            vEntero = vEntero / 5;          // TERMINA EN ;
            // RESIDUOS
            vEntero = vEntero % 5;          // TERMINA EN ;


            // OPERACIONES LOGICAS (COMPARACION)
            int vLocalEntero7 = 10;                 // TERMINA EN ;
            bool resultado = vLocalEntero7 > 3;         // TERMINA EN ; // OPERACION TIPO MAYOR QUE, GENERA UN RESPUESTA DE CIERTO O FALSO
            bool resultado2 = vLocalEntero7 < 3;        // TERMINA EN ; // OPERACION TIPO MENOR QUE, GENERA UN RESPUESTA DE CIERTO O FALSO
            bool resultado3 = vLocalEntero7 != 3;       // TERMINA EN ; // OPERACION TIPO DIFERENTE DE, GENERA UN RESPUESTA DE CIERTO O FALSO
            bool resultado4 = vLocalEntero7 == 3;       // TERMINA EN ; // OPERACION TIPO IGUAL, GENERA UN RESPUESTA DE CIERTO O FALSO



            // TERMINA EN ; // OPERACION DE RELACION AND (Y): SI A ES VERDADERO Y B ES VERDADERO EL RESULTADO ES VERDADERO
            bool resultado5 = vLocalEntero7 > 3 && vLocalEntero7 != 3;
            // TERMINA EN ; // OPERACION DE RELACION OR (O): SI A ES VERDADERO O B ES FALSO EL RESULTADO ES VERDADERO
            bool resultado5 = vLocalEntero7 > 3 || vLocalEntero7 != 3;


            // TERMINA EN ; // OPERACION DE NEGACION (O): SI A ES VERDADERO, EL RESULTADO ES FALSO, VICEVERSA
            bool resultado5 = !resultado5;



            // LAS CONDICIONES SE UTILIZAN EN LAS ESTRUCTURA DE CONTROL, ESTOS NO LLEVAN ;

            // IF (SOLO UN IF), EL IF SE ALIMENTA DE UN VALOR CIERTO O FALSO

            if(resultado)  // ------> ESTO PUEDE SER UNa EXPRESION BOOLEANA (vLocalEntero7 > 3); (vLocalEntero7 > 3 && vLocalEntero7 != 3)
            {
                // AQUI SE EJECUTA SI LA CONDICION FUE VERDADERA
            }


            // IF-ELSE (SE EJECUTA UNO O EL OTRO)
            if(resultado)
            {
                // AQUI SE EJECUTA SI LA CONDICION FUE VERDADERA
            }
            else
            {
                // AQUI SE EJECUTA SI LA CONDICION FUE FALSA
            }            

            // WHILE EL while SE ALIMENTA DE UN VALOR CIERTO O FALSO, NO LLEVA ;
            while(resultado)  // ------> ESTO PUEDE SER UN EXPRESION BOOLEANA (vLocalEntero7 > 3); (vLocalEntero7 > 3 && vLocalEntero7 != 3)
            {
                // ESTO ES LO QUE SE A REPETIR MIENTRA LA CONDICION SE VERDADERA
                // instrucciones
                // Declarar variables
                // Puedo hacer operaciones aritmeticas, logica, relacion
            }


            // DO-WHILE SE ALIMENTA DE UN VALOR CIERTO O FALSO, ESTE SI LLEVA ; AL FINAL DE WHILE
            do{
                // ESTO ES LO QUE SE A REPETIR MIENTRA LA CONDICION SE VERDADERA
                // instrucciones
                // Declarar variables
                // Puedo hacer operaciones aritmeticas, logica, relacion
            }while(resultado);



            // FOR TIENE UNA ESTRUCTURA: INICIALIZACION; CONDICION; INCREMENTO, NO LLEVA ;
            for(int iteracion = 0; iteracion < 10; iteracion++)
            {
                // ESTO ES LO QUE SE A REPETIR MIENTRA LA CONDICION SE VERDADERA
                // instrucciones
                // Declarar variables
                // Puedo hacer operaciones aritmeticas, logica, relacion
            }
            
        }   // NO LLEVA ;




        // ASI SE DECLARA UN METODO ESTATICO Y SIN RETORNO DE DATO (void)
        static void Metodo(int parametro1, int parametro2)     // ESTOS SE LLAMAN PARAMETROS (parametro1, parametro2)
        {
            // DECLARACION DE VARIABLES LOCALES
            int vLocalEntero;
            int vLocalEntero = 10;
            int vLocalEntero1, vLocalEntero2;
            int vLocalEntero3 = 10, vLocalEntero4;


        }

        // METODOS SIN PARAMETRO Y SIN RETORNO DE DATO (void)
        static void MetodoSinParametros()
        {

            // DECLARACION DE VARIABLES LOCALES
            int vLocalEntero;
            int vLocalEntero = 10;
            int vLocalEntero1, vLocalEntero2;
            int vLocalEntero3 = 10, vLocalEntero4;


        }


        // METODO CON PARAMETRO Y CON RETORNO DE DATO (int)
        static int ObtenerEdad(DateTime fechaNacimiento)
        {
            // RETURNO RESULTADO DEL METODO
            return new TimeSpan(DateTime.Now.Ticks - fechaNacimiento.Ticks).GetYear;
        }
    }

    
    // ASI SE DECLARA UNA CLASE
    public class Empleado
    {

        // ESTO SE LLAMAN PROPIEDADES
        // EN LAS PROPIEDADES SE PUEDEN UTILIZAR TIPO DE DATOS PRIMITIVO O TIPO DE DATOS POR REFERENCIA
        public int NumeroEmpleado { get; set; }    
        public string Nombre { get; set; }
        public bool Activo {set; get; }

        // ESTE ES UNA PROPIEDAD DE TIPO DE DATO POR REFERENCIA
        public Direccion Direccion {set; get;}


        // ESTO ES UN METODO DE UNA CLASE
        public string ObtenerNombre()
        {
            return this.Nombre;
        }

    } 

    public class Direccion
    {

        public string Calle { get; set; }
        public string NumeroExterior {get; set;}

    }
}