namespace DesafioFundamentos.Models {

    public class Estacionamento {

        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora) {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo() {

            Console.WriteLine("");
            Console.Write("INFORME A PLACA DO VEÍCULO A SER ESTACIONADO: ");
            string placaNova = Console.ReadLine().ToUpper();
            Console.WriteLine("");

            if (veiculos.Contains(placaNova)) {
                Console.WriteLine($"O VEÍCULO DE PLACA < {placaNova} > JÁ SE ENCONTRA NO SISTEMA!!");
            }
            else {
                Console.Write($"CONFIRME A PLACA < {placaNova} > DO VEÍCULO A SER ESTACIONADO ( S / N ) ");
                
                string confirmation = Console.ReadKey(true).Key.ToString().ToUpper();
                Console.WriteLine("");
                while (confirmation!="S" || confirmation!="N") {
                    if (confirmation == "S") {
                        veiculos.Add(placaNova);
                        Console.WriteLine("!! VEÍCULO CADASTRADO !!");
                        break;
                    }
                    else if (confirmation == "N") {
                        Console.WriteLine("!! CADASTRO CANCELADO !!");
                        break;
                    }
                    else {
                        Console.WriteLine("APERTE < S > OU < N >");
                        confirmation = Console.ReadKey(true).Key.ToString().ToUpper();
                    }
                }
            }
        }

        public void RemoverVeiculo() {

            if (veiculos.Any()) {
                Console.WriteLine("");

                Console.Write("INFORME A PLACA DO VEÍCULO A SER REMOVIDO: ");
                string placa = Console.ReadLine().ToUpper();

                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) {
                    Console.WriteLine("");
                    Console.Write($"CONFIRME A REMOÇÃO DO VEÍCULO < {placa} > ( S / N ) ");
                
                    string confirmation = Console.ReadKey(true).Key.ToString().ToUpper();
                    Console.WriteLine("");
                    
                    while (confirmation!="S" || confirmation!="N") {
                        if (confirmation == "S") {
                            Console.WriteLine("!! REMOÇÃO CONFIRMADA !!");
                            Console.WriteLine("");
                            Console.Write("INFORME QUANTAS HORAS O VEÍCULO FICOU ESTACIONADO: ");
                            int horas = Int32.Parse(Console.ReadLine());
                            decimal valorTotal = precoInicial + precoPorHora * horas; 

                            veiculos.Remove(placa);
                            Console.WriteLine($"!! O VEÍCULO < {placa} > FOI REMOVIDO !!");
                            Console.WriteLine($"   PREÇO TOTAL : R$ {valorTotal}");
                            break;
                        }
                        else if (confirmation == "N") {
                            Console.WriteLine("!! REMOÇÃO CANCELADA !!");
                            break;
                        }
                        else {
                            Console.WriteLine("APERTE < S > OU < N >");
                            confirmation = Console.ReadKey(true).Key.ToString().ToUpper();
                        }
                    }
                }
                else {
                    Console.WriteLine("VEÍCULO NÃO ENCONTRADO.\n" +
                                      "VERIFIQUE SE A PLACA FOI DIGITADA CORRETAMENTE.");
                }
            }
            else {
                Console.WriteLine("");
                Console.WriteLine("!! NÃO HÁ VEÍCULOS ESTACIONADOS !!");
            }
        }

        public void ListarVeiculos() {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any()) {
                Console.WriteLine("");
                Console.WriteLine("OS VEÍCULOS ESTACIONADOS SÃO:");
                for (int i=0; i<veiculos.Count; i++) {
                    Console.WriteLine(" ▸ "+veiculos[i]);
                }
            }
            else {
                Console.WriteLine("");
                Console.WriteLine("!! NÃO HÁ VEÍCULOS ESTACIONADOS !!");
            }
        }
    }
}
