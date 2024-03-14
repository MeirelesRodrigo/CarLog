namespace CarLog.Domain;

public class Veiculo
{
    public Veiculo()
    {
        ExternalId = Guid.NewGuid();
    }

    public Guid ExternalId { get; set; }

    public string Placa { get; set; }

    public string Fabricante { get; set; }

    public string Modelo { get; set; }

    public int AnoFabricacao { get; set; }

    public decimal Km { get; set; }

    public string Status { get; set; }

    public string LocaBase { get; set; }

    public DateTime CadastradoEm { get; set; }
}