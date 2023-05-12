using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.Models
{
    public class ParticipantModel
    {
        // поля из бд
        private int participant_id;
        private string participant_surname;
        private string participant_name;
        private string participant_email;

        [DisplayName("ID")]
        public int Participant_id { get => participant_id; set => participant_id = value; }

        [DisplayName("Фамилия")]
        [Required(ErrorMessage = "Требуется фамилия")]
        public string Participant_surname { get => participant_surname; set => participant_surname = value; }

        [DisplayName("Имя")]
        [Required(ErrorMessage = "Требуется имя")]
        public string Participant_name { get => participant_name; set => participant_name = value; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Требуется e-mail")]
        public string Participant_email { get => participant_email; set => participant_email = value; }

    }
}
