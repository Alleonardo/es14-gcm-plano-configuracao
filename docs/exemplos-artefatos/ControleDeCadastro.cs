[Table("ControleDeCadastro", Schema = "dbo")]
public partial class ControleDeCadastroEntity
{
    #region Construtor
    public ControleDeCadastroEntity()
    {
        OnCreated();
    }
    #endregion

    #region Propriedades
    [Key]
    [Required]
    [Column(TypeName = "int", Order = 0)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public virtual int Id { get; set; }
    [Required]
    [Column(TypeName = "varchar", Order = 1)]
    public virtual string Nome { get; set; }
    [Required]
    [Column(TypeName = "varchar", Order = 3)]
    public virtual string Logradouro { get; set; }
    [Required]
    [Column(TypeName = "int", Order = 4)]
    public virtual int Numero { get; set; }
    [Required]
    [Column(TypeName = "string", Order = 5)]
    public virtual string Bairro { get; set; }
    [Required]
    [Column(TypeName = "string", Order = 6)]
    public virtual string Cidade { get; set; }
    [Required]
    [Column(TypeName = "string", Order = 7)]
    public virtual string Cep { get; set; }
    [Required]
    [Column(TypeName = "datetime", Order = 8)]
    public virtual DateTime DataCadastro { get; set; }
    #endregion
}
