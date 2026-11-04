public static class Pedagio
{
    private static int passagensComSucesso;
    private static int tentativaSemSaldo;

    public static int PassagensComSucesso
    {
        get { return passagensComSucesso; }
    }
    public static int TentativaSemSaldo
    {
        get { return tentativaSemSaldo; }
    }

    static Pedagio()
    {
        passagensComSucesso = 0;
        tentativaSemSaldo = 0;
    }

    public static void PassouComSucesso(Veiculo veiculo)
    {
        passagensComSucesso++;
    }
    public static void SemSaldo(Veiculo veiculo)
    {
        tentativaSemSaldo++;
    }
    public static bool PassarPedagio(Veiculo veiculo)
    {
        if (veiculo._id.ObterSaldo() >= 2.90m)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool VerificarCancela(Tag tag)
    {
        if (tag.ObterSaldo() >= 2.90m)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}