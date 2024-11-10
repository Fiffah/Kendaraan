using System.ComponentModel.DataAnnotations;

namespace Kendaraan.Models
{
  public class VehicleModel
{
    [Key]
    [Required]
    public string NomorRegistrasiKendaraan { get; set; } = string.Empty;

    [Required]
    public string NamaPemilik { get; set; } = string.Empty;

    public string Alamat { get; set; } = string.Empty;
    public string MerkKendaraan { get; set; } = string.Empty;

    [Range(1900, 2100)]
    public int TahunPembuatan { get; set; }

    public int KapasitasSilinder { get; set; }
    public string WarnaKendaraan { get; set; } = string.Empty;

    [Required]
    public string BahanBakar { get; set; } = string.Empty;
}
}
