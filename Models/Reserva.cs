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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            bool possivelCadastrar = Suite.Capacidade >= hospedes.Count();
            if (possivelCadastrar)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new LimiteDeHospedesExcedidoException("O número de hóspedes excede o capacidade máxima permitida");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*

            decimal valorDiaria = Suite.ValorDiaria;
            decimal valor = DiasReservados * valorDiaria;
            

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                decimal valorDoDesconto = valor * 0.10m;
                decimal precoComDesconto = valor - valorDoDesconto;

                valor = precoComDesconto;
            }

            return valor;
        }
    }
}