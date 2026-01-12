namespace Lab1Prog3
{
    internal class Program
    {
        static void Main(string[] args)

        { //Atividade 1

            Console.WriteLine("Recebendo os parametros:");
            Console.WriteLine();

            foreach (string param in args)
            {
                Console.WriteLine(param);
            }


            //Atividade 2
            Console.WriteLine("Conversões:");
            //valores para atividade 2
            int intValue = 42;
            float floatValue = 42.58f;
            double doubleValue = 123456789.123456;
            string stringValue = "12345";
            bool boolValue = true;
            object objectValue = "12345";
            short shortValue = 123;
            long longValue = 1234567890;


            //float para int e int para float
            static int FloatToInt(float value)
            {
                return (int)value;
            }

            static float IntToFloat(int value)
            {
                return value;
            }

            //int para short e int para long
            static short IntToShort(int value)
            {
                return (short)value;
            }

            static long IntToLong(int value)
            {
                return (long)value;
            }

            //int para double
            static double IntToDouble(int value)
            {
                return (double)value;
            }

            //bool para string
            static string BoolToString(bool value)
            {
                return value.ToString();
            }

            //int para string
            static string IntToString(int value)
            {
                return value.ToString();
            }

            //boxing e unboxing
            static object BoxInt(int value)
            {
                return (object)value;
            }

            static int UnboxInt(object value)
            {
                return (int)value;
            }


            //Testando as conversões
            Console.WriteLine($"Float para Int: {FloatToInt(floatValue)}");
            Console.WriteLine($"Int para Float: {IntToFloat(intValue)}");
            Console.WriteLine($"Int para Short: {IntToShort(intValue)}");
            Console.WriteLine($"Int para Long: {IntToLong(intValue)}");
            Console.WriteLine($"Int para Double: {IntToDouble(intValue)}");
            Console.WriteLine($"Bool para String: {BoolToString(true)}");
            Console.WriteLine($"Int para String: {IntToString(intValue)}");
            object boxedInt = BoxInt(intValue);
            Console.WriteLine($"Boxing Int: {boxedInt}");
            Console.WriteLine($"Unboxing Int: {UnboxInt(boxedInt)}");
        }
    }
}