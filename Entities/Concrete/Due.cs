using Core.Entities;

namespace Entities.Concrete
{
    public class Due : IEntity
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public double OcakAidat { get; set; }
        public double SubatAidat { get; set; }
        public double MartAidat { get; set; }
        public double NisanAidat { get; set; }
        public double MayisAidat { get; set; }
        public double HaziranAidat { get; set; }
        public double TemmuzAidat { get; set; }
        public double AgustosAidat { get; set; }
        public double EylulAidat { get; set; }
        public double EkimAidat { get; set; }
        public double KasimAidat { get; set; }
        public double AralikAidat { get; set; }
    }
}
