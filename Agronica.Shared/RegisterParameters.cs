using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Agronica.Shared
{
    public class RegisterParameters
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
        public string PasswordConfirm { get; set; }

        [Required]
        public string Correo { get; set; }

        [Required]
        [Compare(nameof(Correo), ErrorMessage = "Correo no coincide")]
        public bool CorreoConfirm { get; set; }
    }
}
