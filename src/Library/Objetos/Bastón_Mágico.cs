namespace Library
{
    public class LibroDeEchizos
    {
        public int Daño {get; private set;} = 0;
        public int Defensa {get; private set;} = 0;

        public void NuevoEchizo(Echizo echizo)
        {
            this.Ataque += echizo.Ataque;
            this.Defensa += echizo.Defensa;
        }
