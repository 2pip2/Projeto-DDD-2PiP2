using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Domain.Entities
{
    public class Maquinas
    {
        public int MaquinasId { get; set; }
        public string TAG { get; set; }
        public int HorimetroIncial { get; set; }
        public int Capacidade { get; set; }
        public int HorimetroUltimaRevisao { get; set; }
        public bool Proprio { get; set; }
        public bool ProducaoDiaria { get; set; }
        public bool GestaoHorimetro { get; set; }
        public int NumeroSerie { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataEntrega { get; set; }
        public DateTime DataTerminoGarantia { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int EquipamentoId { get; set; }
        public virtual Equipamento Equipamento { get; set; }
        public int IdFabricante { get; set; }
        public  virtual Fabricante Fabricante { get; set; }
        public int ModeloId { get; set; }
        public virtual Modelo Modelo { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
        public bool Alerta (Horas_Programadas horasprogramadas,Horimetro horimetro)
        {
            if (horimetro.ValorHorimetro - horasprogramadas.HorasProgramadas == 0) { return true; }
            else { return false; }
        }


    }
}
