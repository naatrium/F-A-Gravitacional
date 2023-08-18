
      
        // área de declaração, poderia ter feito isso só quando a variável é chamada, 
        // mas como o programa é muito grande, decidi fazer assim:
        // nos planetas, tem a massa deles como valor, e também temos a constante G.
        string opcao;
        double forçaG, dist, massa1, massa2;
        double sol = 1.98 * Math.Pow(10, 30);
        double terra = 5.972 * Math.Pow(10, 24);
        double mercurio = 3.285 * Math.Pow(10, 23);
        double venus = 4.867 * Math.Pow(10, 24);
        double marte = 6.39 * Math.Pow(10, 23);
        double jupiter = 1.898 * Math.Pow(10, 27);
        double saturno = 5.683 * Math.Pow(10, 26);
        double netuno = 1.024 * Math.Pow(10, 26);
        double urano = 8.681 * Math.Pow(10, 25);
        double G = 6.67 * Math.Pow(10, -11);

        // resolvi fazer uma estrutura de repetição, somente com o switch principal, que tem/mostra as 3 opções iniciais:
        do
        {
            Console.WriteLine("1 - Se deseja calcular entre o Sol + qualquer planeta do nosso sistema solar.");
            Console.WriteLine("2 - Se deseja calcular entre a Terra + qualquer planeta do nosso sistema solar.");
            Console.WriteLine("3 - Se deseja fazer o cálculo com outros corpos celestes.");
            Console.WriteLine("4 - Se deseja fechar o programa.");
            Console.WriteLine("Sua opção?");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("1 - Sol + Mércurio");
                    Console.WriteLine("2 - Sol + Vênus");
                    Console.WriteLine("3 - Sol + Terra");
                    Console.WriteLine("4 - Sol + Marte");
                    Console.WriteLine("5 - Sol + Júpiter");
                    Console.WriteLine("6 - Sol + Saturno");
                    Console.WriteLine("7 - Sol + Urano");
                    Console.WriteLine("8 - Sol + Netuno");
                    Console.WriteLine("Sua opção?");
                    opcao = Console.ReadLine();
                    // Força de atração gravitacional entre o Sol + todos os planetas do nosso sistema solar.
                    // Caso 1, mostrar as opções de todos os planetas do nosso sistema solar + Sol. 
                    switch (opcao)
                    {
                        case "1":
                            dist = 57.91 * Math.Pow(10, 6);
                            forçaG = G * (sol * mercurio) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre o Sol e Mércurio é de aproximadamente: " + forçaG + " N.");
                            break;
                        case "2":
                            dist = 108.2 * Math.Pow(10, 6);
                            forçaG = G * (sol * venus) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre o Sol e Vênus é de aproximadamente: " + forçaG + " N.");
                            break;
                        case "3":
                            dist = 149.6 * Math.Pow(10, 6);
                            forçaG = G * (sol * terra) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre o Sol e a Terra é de aproximadamente: " + forçaG + " N.");
                            break;
                        case "4":
                            dist = 227.9 * Math.Pow(10, 6);
                            forçaG = G * (sol * marte) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre o Sol e Marte é de aproximadamente: " + forçaG + " N.");
                            break;
                        case "5":
                            dist = 778.5 * Math.Pow(10, 6);
                            forçaG = G * (sol * jupiter) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre o Sol e Júpiter é de aproximadamente: " + forçaG + " N.");
                            break;
                        case "6":
                            dist = 1.429 * Math.Pow(10, 9);
                            forçaG = G * (sol * saturno) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre o Sol e Saturno é de aproximadamente: " + forçaG + " N.");
                            break;
                        case "7":
                            dist = 2.871 * Math.Pow(10, 9);
                            forçaG = G * (sol * urano) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre o Sol e Urano é de aproximadamente: " + forçaG + " N.");
                            break;
                        case "8":
                            dist = 4.495 * Math.Pow(10, 9);
                            forçaG = G * (sol * netuno) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre o Sol e Netuno é de aproximadamente: " + forçaG + " N.");
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("1 - Terra + Mércurio");
                    Console.WriteLine("2 - Terra + Vênus");
                    Console.WriteLine("3 - Terra + Marte");
                    Console.WriteLine("4 - Terra + Júpiter");
                    Console.WriteLine("5 - Terra + Saturno");
                    Console.WriteLine("6 - Terra + Urano");
                    Console.WriteLine("7 - Terra + Netuno");
                    Console.WriteLine("Sua opção?");
                    opcao = Console.ReadLine();
                    // Força de atração gravitacional entre a Terra + todos os planetas do nosso sistema solar. 
                    // Caso 2, mostrar as opções de todos os planetas do nosso sistema solar + Terra.
                    switch (opcao)
                    {
                        case "1":
                            dist = 57.91 * Math.Pow (10,9);
                            forçaG = G * (terra * mercurio) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre a Terra e Mércurio é de aproximadamente: " + forçaG + " N.");
                            break;
                        case "2":
                            dist = 41000000000;
                            forçaG = G * (terra * venus) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre a Terra e Vênus é de aproximadamente: " + forçaG + " N.");
                            break;
                        case "3":
                            dist = 225000000000;
                            forçaG = G * (terra * marte) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre a Terra e Marte é de aproximadamente: " + forçaG + " N.");
                            break;
                        case "4":
                            dist = 778000000000;
                            forçaG = G * (terra * jupiter) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre a Terra e Júpiter é de aproximadamente: " + forçaG + " N.");
                            break;
                        case "5":
                            dist = 1400000000000;
                            forçaG = G * (terra * saturno) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre a Terra e Saturno é de aproximadamente: " + forçaG + " N.");
                            break;
                        case "6":
                            dist = 2900000000000;
                            forçaG = G * (terra * urano) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre a Terra e Urano é de aproximadamente: " + forçaG + " N.");
                            break;
                        case "7":
                            dist = 4500000000000;
                            forçaG = G * (terra * netuno) / Math.Pow(dist, 2);
                            Console.WriteLine("A força de atração gravitacional entre a Terra e Netuno é de aproximadamente: " + forçaG + " N.");
                            break;
                    }
                    break;
                case "3":
                    // Lógica para cálculo com outros corpos celestes.
                    // Se deseja realizar o cálculo com outros corpos, pergunta as informações.
                    Console.WriteLine("Insira as massas dos dois corpos celestes (em quilogramas):");
                    massa1 = double.Parse(Console.ReadLine());
                    massa2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira a distância entre os corpos celestes (em metros):");
                    dist = double.Parse(Console.ReadLine());
                    forçaG = G * (massa1 * massa2) / Math.Pow(dist, 2);
                    Console.WriteLine("A força de atração gravitacional entre os corpos celestes é de aproximadamente: " + forçaG + " N.");
                    break;
            }
        } while (opcao != "4");
