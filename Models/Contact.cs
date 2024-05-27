using System.ComponentModel.DataAnnotations;
namespace CommunicationForm.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad ve soyad alanı gereklidir.")]
        public required string FullName { get; set; }

        [Required(ErrorMessage = "Telefon numarası alanı gereklidir.")]
        public required string Phone { get; set; }

        [Required(ErrorMessage = "E-posta adresi alanı gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Departman alanı gereklidir.")]
        public required string Department { get; set; }

        [Required(ErrorMessage = "Mesaj alanı gereklidir.")]
        public required string Message { get; set; }

    }
}
