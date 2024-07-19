using bytebank.Modelos.ADM.Funcionarios;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_GeradorChavePix;
using bytebank_Modelos.bytebank.Modelos.ADM.Utilitario;
using System.Threading.Channels;
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//new ByteBankAtendimento().AtendimentoCliente();

//AutenticacaoUtil autenticador = new AutenticacaoUtil();

//public class Estagiario : Funcionario
//{
//    public Estagiario(double salario, string cpf) : base(salario, cpf) { }
//    public override void AumentarSalario()
//    {
//        this.Salario *= 1.05;
//    }
//    protected override double getBonificacao()
//    {
//        return this.Salario * 0.05;
//    }

//}

Console.WriteLine(GeradorPix.GetChavePix());