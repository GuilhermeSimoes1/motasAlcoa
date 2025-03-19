using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace motasAlcoa.Models
{

    /// <summary>
    /// Representa a relação entre uma encomenda e as peças associadas.
    /// Cada instância desta classe indica a quantidade de uma peça específica 
    /// dentro de uma determinada encomenda.
    /// </summary>

    [PrimaryKey(nameof(EncomendaFK), nameof(PecaFK))]
    public class EncomendaPecas
    {
        /// <summary>
        /// Identificador da encomenda
        /// </summary>
        [ForeignKey(nameof(Encomenda))]
        public int EncomendaFK { get; set; }

        /// <summary>
        /// Fk para a encomenda
        /// </summary>
        public Encomendas Encomenda { get; set; }

        /// <summary>
        /// Identificador da peça
        /// </summary>
        [ForeignKey(nameof(Peca))]
        public int PecaFK { get; set; }

        /// <summary>
        /// FK para a peça
        /// </summary>
        public Pecas Peca {  get; set; }

        /// <summary>
        /// Número de unidades da peça solicitada no pedido
        /// </summary>
        public int Quantidade{ get; set; }

    }
}
