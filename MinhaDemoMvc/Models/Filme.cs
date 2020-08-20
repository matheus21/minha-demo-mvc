using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        //Chave primária
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="O Título precisa ter entre 3 ou 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage ="Data em formato incorreto")]
        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\W-]*$", ErrorMessage ="Gênero em formato inválido")]
        //Podem ser adicionadas mais annotations em uma linha, utilizando sobrecarga
        [StringLength(30, ErrorMessage ="Máximo de 30 caracteres"), Required(ErrorMessage ="O campo gênero é obrigatório")]
        public string Genero { get; set; }

        [Range(1,1000, ErrorMessage ="Valor de 1 a 1000")]
        [Required(ErrorMessage = "Preencha o campo Valor")]
        //Annotations de definição de banco de dados
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [RegularExpression(@"^[0-5]*$", ErrorMessage ="Somente números entre 0 e 5")]
        [Required(ErrorMessage = "Preencha o campo Avaliação")]
        [Display(Name ="Avaliação")]
        public int Avaliacao { get; set; }
    }
}
