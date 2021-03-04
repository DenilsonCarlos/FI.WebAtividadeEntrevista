namespace WebAtividadeEntrevista.Models
{
    public class BeneficiarioModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
    //    [Required]
        public string CPF { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
    //    [Required]
        public string Nome { get; set; }

        /// <summary>
        /// IDCLIENTE
        /// </summary>
        public long IDCLIENTE { get; set; }

        /// <summary>
        /// AcaoDoItem
        /// </summary>
        public string AcaoDoItem { get; set; }


    }
}