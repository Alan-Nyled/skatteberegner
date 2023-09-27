    public class Beregning {
        static void Main(string[] args) {

        }
        
        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double SkatVedJulegave(double julegave, double andenGave) {
            double gavesum = julegave + andenGave;
            if(gavesum <= 1200){
                return 0;
            }
            if(andenGave > 300 && julegave <= 900){
                return andenGave;
            }
            return gavesum;
        }
    }