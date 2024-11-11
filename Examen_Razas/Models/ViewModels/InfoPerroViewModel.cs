namespace Examen_Razas.Models.ViewModels
{
    public class InfoPerroViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string OtroNombre { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Patas { get; set; } = null!;
        public string Cola { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Pelo { get; set; } = null!;
        public int PesoMax { get; set; }
        public int PesoMin { get; set; }
        public int AlruraMax { get; set; }
        public int AlruraMin { get; set; }
        public int EsperanzaVida { get; set; }
        public string Hosico { get; set; } = null!;
    }

}
