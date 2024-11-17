using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCadastroEvento.Models
{
    public class Evento
    {
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Propriedade calculada para duração do evento
        public int DuracaoDias => (DataTermino - DataInicio).Days;

        // Propriedade calculada para custo total
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}
