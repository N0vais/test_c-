internal class Program
{
    private static void Main(string[] args)
    {
        static void p1001()
        {
            // EX 1000
            //Console.Write("Hello World!\n");

            int a, b, x;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            x = a + b;

            Console.Write("X = {0}\n", x);
            //Console.Write("O valor da soma é = {0}\n", x);
        }

        static void p1002()
        {
            double area, raio;

            raio = Convert.ToDouble(Console.ReadLine());

            area = 3.14159 * (raio * raio);

            Console.Write("A={0}\n", area.ToString("0.0000"));

            Console.Write("OK");
        }
        static void p1003()
        {

            int a, b, soma;

            Console.Write("Digite um valor? ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro valor? ");
            b = Convert.ToInt32(Console.ReadLine());

            soma = a + b;

            Console.Write("SOMA = {0}\n", soma);
        }

        static void p1004()
        {
            int prod, a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            prod = a * b;

            Console.Write("PROD = {0}\n", prod);
        }

        static void p1005()
        {

            double a, b, media;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());

            media = (a * 3.5 + b * 7.5) / (3.5 + 7.5);

            Console.Write("Media = {0}\n", media.ToString("0.00000"));

        }

        static void p1006(){

            double a, b, c, media;

            a= Convert.ToDouble(Console.ReadLine());
            b= Convert.ToDouble(Console.ReadLine());
            c= Convert.ToDouble(Console.ReadLine());

            media = (a * 2 + b * 3 + c * 5)/(2 + 3 + 5);

            Console.Write("Media = {0}\n", media.ToString("0.0"));

        }

        static void p1007()
        {

            int a, b, c, d, diferente;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            diferente = a * b - c * d;

            Console.Write("DIFERENÇA = {0}\n", diferente);
        }

        static void p1008()
        {
            int numero, horas;
            double salario, total;

            numero = Convert.ToInt32(Console.ReadLine());
            horas = Convert.ToInt32(Console.ReadLine());

            salario = Convert.ToDouble(Console.ReadLine());

            total = horas * salario;

            Console.Write("NUMBER = {0}\n", numero);
            Console.Write("SALARY = U$ {0}\n", total.ToString("0.00"));
        }

        static void p1009()
        {

            string nome;
            double salario, vendas, resultado;

            nome = Convert.ToString(Console.ReadLine());
            salario = Convert.ToDouble(Console.ReadLine());
            vendas = Convert.ToDouble(Console.ReadLine());

            resultado = salario + vendas / 100 * 15;

            Console.Write("TOTAL = R$ {0}\n", resultado.ToString("0.00"));

        }

        static void p1010()
        {


            string[] valor1 = Console.ReadLine().Split();
            int cod1 = Convert.ToInt32(valor1[0]);
            int pecas1 = Convert.ToInt32(valor1[1]);
            double saldo1 = Convert.ToDouble(valor1[2]);

            string[] valor2 = Console.ReadLine().Split();
            int cod2 = Convert.ToInt32(valor2[0]);
            int pecas2 = Convert.ToInt32(valor2[1]);
            double saldo2 = Convert.ToDouble(valor2[2]);

            double resultado = pecas1 * saldo1 + pecas2 * saldo2;
            Console.Write("VALOR A PAGAR: R$ {0}\n", resultado.ToString("0.00"));
        }

        static void p1011()
        {
            double raio, caculo;

            raio = Convert.ToDouble(Console.ReadLine());
            caculo = 4 / 3.0 * 3.14159 * (raio * raio * raio);
            Console.Write("VOLUME = {0}\n", caculo.ToString("0.000"));
        }

        static void p101()
        {
            double a, b, c, tri, cir, tra, qua, ret;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            tri = a * c / 2;
            cir = c * c * 3.14159;
            tra = (a + b) * c / 2;
            qua = b * b;
            ret = a * b;

            Console.Write("TRIANGULO: {0}\n", tri.ToString("0.000"));
            Console.Write("CIRCULO: {0}\n", cir.ToString("0.000"));
            Console.Write("TRAPEZIO: {0}\n", tra.ToString("0.000"));
            Console.Write("QUADRADO: {0}\n", qua.ToString("0.000"));
            Console.Write("RETANGULO: {0}\n", ret.ToString("0.000"));
        }

        static void p1012()
        {

            double tri, cir, tra, qua, ret;

            string[] valor2 = Console.ReadLine().Split();
            double a = Convert.ToDouble(valor2[0]);
            double b = Convert.ToDouble(valor2[1]);
            double c = Convert.ToDouble(valor2[2]);

            tri = a * c / 2;
            cir = c * c * 3.14159;
            tra = (a + b) * c / 2;
            qua = b * b;
            ret = a * b;

            Console.Write("TRIANGULO: {0}\n", tri.ToString("0.000"));
            Console.Write("CIRCULO: {0}\n", cir.ToString("0.000"));
            Console.Write("TRAPEZIO: {0}\n", tra.ToString("0.000"));
            Console.Write("QUADRADO: {0}\n", qua.ToString("0.000"));
            Console.Write("RETANGULO: {0}\n", ret.ToString("0.000"));
        }

        static void p1013()
        {

            string[] maior = Console.ReadLine().Split();
            int a = int.Parse(maior[0]);
            int b = int.Parse(maior[1]);
            int c = int.Parse(maior[2]);

            int maiora = (a + b + Math.Abs(a - b)) / 2;
            int maiorac = (maiora + c + Math.Abs(maiora - c)) / 2;

            Console.Write($"{maiorac} eh o maior");

        }

        static void p1014()
        {
            int x;
            double y, total;

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            total = x / y;

            Console.WriteLine("{0} km/l", total.ToString("0.000"));

        }

        static void p1015()
        {
            double x, y;

            string[] eixo_x = Console.ReadLine().Split();

            double x1 = double.Parse(eixo_x[0]);
            double y1 = double.Parse(eixo_x[1]);

            string[] eixo_y = Console.ReadLine().Split();
            double x2 = double.Parse(eixo_y[0]);
            double y2 = double.Parse(eixo_y[1]);

            double distancia = Math.Sqrt(Math.Pow(x = (x2 - x1),2) + Math.Pow(y =(y2 - y1),2));

            Console.WriteLine("{0}", distancia.ToString("0.0000"));

        }

        static void p1016(){
            int numero, kilometro;

            numero = Convert.ToInt32(Console.ReadLine());
            kilometro = (numero * 2);

            Console.WriteLine("{0} minutos", kilometro);
        }

        static void p1017(){
            double a, b, soma;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());

            soma = (a*b) / 12;

            Console.WriteLine("{0}", soma.ToString("0.000"));
        }
//exercicio pedido em aula .//
        static void p0003(){

            int dia, semana, resto_semana, primeiro_dia;

            Console.WriteLine("Digite a semana do dia 1 : ");
            primeiro_dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um dia da semana: ");
            dia = Convert.ToInt32(Console.ReadLine());

            semana = dia/7;
            Console.Write("Semanas completas = {0}\n", semana);

            resto_semana = (dia - (semana *7) + (primeiro_dia -1))%7;
            Console.Write("Dias que restaram = {0}\n", resto_semana);

            switch(resto_semana){
                case 1: Console.Write("Domingo"); break;
                case 2: Console.Write("Segunda"); break;
                case 3: Console.Write("terça"); break;
                case 4: Console.Write("Quarta"); break;
                case 5: Console.Write("Quinta"); break;
                case 6: Console.Write("Sexta"); break;
                case 0: Console.Write("Sabado"); break;
            }
        }
        

        //tabuada\\
        static void p0004(){
            /*int n = 1;
            while(n <= 5){
                Console.Write("n = {0} (while)\n", n);
                n++;
            }
            n = 1;
            do{
                Console.Write("n = {0} (do_while)\n", n);
                n++;
            }while (n <= 5 );*/
             
             
            int numero,limite;
            int n =1;

            Console.Write("Digite a tabuada: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o limite da tabuada: ");
            limite = Convert.ToInt32(Console.ReadLine());
 
            for(numero = 2; numero <= 9; numero++){
                Console.Write("\n\n-------------{0}------------\n",numero);
            for (n = 1; n  <= limite; n++){
                Console.Write("{0} X {1} = {2}\n", numero, n, n*numero);
            }
        }
        }
        
        
        static void p0005(){
            int N = 5,L,C;

            Console.Write("\n\n--------1-------\n\n");

            for(L = 0; L < N; L++){
                Console.Write("X ");
            }
            
            Console.Write("\n\n--------2-------\n\n");
            for(L = 0; L < N; L++){
                for(C = 0; C < N; C++){
                    Console.Write("X ");
                }
                Console.Write("\n");
            }

            Console.Write("\n\n--------3-------\n\n");
            for(L = 0; L < N; L++){
                for(C = 0; C <=L; C++){
                    Console.Write("X ");
                }
                Console.Write("\n");
            }

            Console.Write("\n\n--------4-------\n\n");
            for(L = 0; L <= N; L++){
                for(  C = 0; C <= L; C++)
                    Console.Write(" ");
                for(C = N - 1; C >=L; C--)
                    Console.Write("X ");
                    Console.Write("\n");
                }

            Console.Write("\n\n--------5-------\n\n");
            for(L = 0; L <= N; L++){
                for(C = N -1; C >=L; C--)
                    Console.Write(" ");
                for(C = 0; C <= L; C++)
                    Console.Write("X ");
                    Console.Write("\n");
                }

            Console.Write("\n\n--------6-------\n\n");
            for(L = 0; L <= N; L++){
                for(C = N -1; C >=L; C--){
                    Console.Write("X ");
                }
                Console.Write("\n");
            }

        }
        //  INICIO DO PROGRAMA

        int prog;
        Console.Clear();
        do
        {

            Console.Write("\nGerenciador de programas:\n");
            Console.Write("\n\t| 0 para sair |\nDigite o programa desejado: ");
            prog = Convert.ToInt32(Console.ReadLine());
            if (prog == 0)
            {
                Console.Write("\nObrigado por utilizar nossos programas.\n");
                break;
            }

            switch (prog)
            {
                case 1001: p1001(); break;
                case 1002: p1002(); break;
                case 1003: p1003(); break;
                case 1004: p1004(); break;
                case 1005: p1005(); break;
                case 1006: p1006(); break;
                case 1007: p1007(); break;
                case 1008: p1008(); break;
                case 1009: p1009(); break;
                case 1010: p1010(); break;
                case 1011: p1011(); break;
                case 1012: p1012(); break;
                case 1013: p1013(); break;
                case 1014: p1014(); break;
                case 1015: p1015(); break;
                case 1016: p1016(); break;
                case 1017: p1017(); break;
                case 0003: p0003(); break;
                case 0004: p0004(); break;
                case 0005: p0005(); break;

                default: Console.Write("\nOpção Inválida\n"); break;
            }
        } while (prog != 0);
    }
} 
//p1001();
//p1002();
