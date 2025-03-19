using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace motasAlcoa.Models
{
    ///
    /// <summary>
    /// Representa a relação entre os serviços realizados e as peças utilizadas.
    /// Cada registro nesta tabela indica quantas unidades de uma peça foram usadas
    /// num serviço específico.
    /// </summary>
    /// 

    [PrimaryKey(nameof(ServicosFK), nameof(PecaFK))]
    public class ServicoPecas
    {
        /// <summary>
        /// Identificador do serviço que está associado 
        /// ao relacionamento entre serviços e peças
        /// </summary>
 
        [ForeignKey(nameof(Servico))]
        public int ServicosFK { get; set; }

        /// <summary>
        /// FK para os serviços
        /// </summary>
        public Servicos Servico { get; set; }


        /// <summary>
        /// Identificador da peça que está associada    
        /// ao relacionamento entre serviços e peças
        /// </summary>

        [ForeignKey(nameof(Peca))]
        public int PecaFK { get; set; }

        /// <summary>
        /// FK para as peças
        /// </summary>
        public Pecas Peca {  get; set; }

        /// <summary>
        /// Quantidade da peça usada no serviço
        /// </summary>
        [Required]
        public int QuantidadeUsada { get; set; }



    }
}
