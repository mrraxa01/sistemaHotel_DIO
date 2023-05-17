namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
           
            
            if (Suite.Capacidade < hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                
                throw ("A suíte não suporta a quantidade de hóspedes!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            
            
            // *IMPLEMENTE AQUI*
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            
            if (DiasReservados >= 10)
            {
                valor = valor - (valor * .10);
            }

            return valor;
        }
    }
}