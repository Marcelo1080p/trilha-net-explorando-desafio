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
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                Exception ex = new Exception();
                Console.WriteLine($"O número de hóspedes não pode ser maior que a capacidade suportada pela suite: {ex.Message}");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = Suite.ValorDiaria * DiasReservados;


            if (DiasReservados >= 10)
            {
                decimal desconto = Suite.ValorDiaria * (100.0m / 100);
                Console.WriteLine(desconto);
                valor -= desconto;
            }

            return valor;
        }
    }
}