using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoDeLaboratorios.Models
{
    public class Computadores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public string Marca { get; set; }
        public string Processador { get; set; }
        public string PlacaMae { get; set; }
        public string Memoria { get; set; }
        public string HD { get; set; }
        public string NumeroPratrimonio { get; set; }
        public string Datadecompra { get; set; }

        public Computadores()
        {
        }

        public Computadores(string marca, string processador, string placaMae, string memoria, string hd, string numeroPratrimonio, string datadecompra)
        {
            Marca = marca;
            Processador = processador;
            PlacaMae = placaMae;
            Memoria = memoria;
            HD = hd;
            NumeroPratrimonio = numeroPratrimonio;
            Datadecompra = datadecompra;
        }

    }
}
