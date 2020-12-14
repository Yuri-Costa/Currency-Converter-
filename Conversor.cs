namespace currency_converter
{ 
    public static class Conversor
    {
        
        private static float cotacaoDolar = 5.10f;
        private static float cotacaoEuro= 6.22f;
        public static float valorUsuario;

    
        //  metodos
        public static float RealParaDolar(){
            return valorUsuario / cotacaoDolar;
        }

          public static float DolarParaReal(){
            return valorUsuario * cotacaoDolar;
        }
         public static float RealParaEuro(){
            return valorUsuario / cotacaoEuro;
        }
          public static float EuroParaReal(){
            return valorUsuario * cotacaoEuro;
        }

        

        
    }
}