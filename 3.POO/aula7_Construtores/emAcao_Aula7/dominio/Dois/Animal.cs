class Animal
{
    public string Especie { get; set; }
    public string Habitat { get; set; }

    public Animal(string especie) : base()
    {
        this.Especie = especie;

    }
    public Animal(string especie, string habitat) : this(especie)
    {
        this.Habitat = habitat;
    }
}