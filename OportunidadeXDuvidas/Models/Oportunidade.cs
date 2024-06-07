using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Oportunidade
    {
        [Key]
        public int _id { get; set; }
        public string _descricao { get; set; }
        public DateTime _dataEntrega { get; set; }
        public string _nivelSurto { get; set; }
        public int _qntHoras { get; set; }
        public long _qntErros { get; set; }
        public long _aprendizadoNivel { get; set; }
        public long _horasDeSono { get; set; }
        public int _horasFolga { get; set; }
    }
}
