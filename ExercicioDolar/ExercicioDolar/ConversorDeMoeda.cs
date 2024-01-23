namespace ExercicioDolar
{
    class ConversorDeMoeda
    {
        
        public static double Iof = 6.0;

        public static double Dolar(double cotacao, double compra)
        {

            double total = cotacao * compra;
            return total + total * Iof / 100;
        }

    }
}
