public static class Pedagio
{
    private static int passagensComSucesso;
    private static int tentativasSemSaldo;

    public static int PassagensComSucesso
    {
        get { return passagensComSucesso; }
    }
    public static int TentativasSemSaldo
    {
        get { return tentativasSemSaldo; }
    }

    static Pedagio()
    {
        passagensComSucesso = 0;
        tentativasSemSaldo = 0;
    }

    public static bool PassarPedagio(Veiculo veiculo)
    {
        if (veiculo._id.ObterSaldo() >= 2.90m)
        {
            passagensComSucesso++;
            return true;

        }
        else
        {
           tentativasSemSaldo++;
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