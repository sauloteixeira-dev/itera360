public class Pedagio : IPedagio
{
    public bool PassarPedagio(Veiculo veiculo)
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

    public bool VerificarCancela(Tag tag)
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