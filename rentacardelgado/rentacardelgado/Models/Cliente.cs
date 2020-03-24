using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rentacardelgado.Models
{
    public class Cliente
    {

        public int Id { get; set; }
        [Required]

        public String Nombre { get; set; }


        public String Telefono { get; set; }


        public String Licencia { get; set; }


        public String Carro { get; set; }


        public int Dias { get; set; }

    }
}
