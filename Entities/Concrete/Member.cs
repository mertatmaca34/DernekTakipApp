using Core.Entities;

namespace Entities.Concrete
{
    public class Member : IEntity
    {
        public string TcKimlik { get; set; }
        public string AdSoyad { get; set; }
        public string KanGrubu { get; set; }
        public string Sehir { get; set; }
        public bool Aktif { get; set; }
    }
}
