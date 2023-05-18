using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Курсач.Models
{
    public class ConfModel
    {
        // поля из бд
        private int conf_id;
        private string conf_topic;
        private string conf_organizer_id;
        private string conf_date;
        private string conf_time;
        private string conf_address;
        private int curr_num_of_participants;
        private int max_num_of_participants;

        [DisplayName("ID")]
        public int Conf_id { get => conf_id; set => conf_id = value; }

        [DisplayName("Тема")]
        [Required(ErrorMessage = "Требуется тема")]
        public string Conf_topic { get => conf_topic; set => conf_topic = value; }

        [DisplayName("ID организатора")]
        [Required(ErrorMessage = "Требуется ID организатора")]
        public string Conf_organizer_id { get => conf_organizer_id; set => conf_organizer_id = value; }

        [DisplayName("Дата")]
        [Required(ErrorMessage = "Требуется дата")]
        public string Conf_date { get => conf_date; set => conf_date = value; }

        [DisplayName("Время")]
        [Required(ErrorMessage = "Требуется время")]
        public string Conf_time { get => conf_time; set => conf_time = value; }

        [DisplayName("Адрес")]
        [Required(ErrorMessage = "Требуется адрес")]
        public string Conf_address { get => conf_address; set => conf_address = value; }

        [DisplayName("Количество участников")]
        public int Curr_num_of_participants { get => curr_num_of_participants; set => curr_num_of_participants = value; }

        [DisplayName("Макс. количество участников")]
        [Required(ErrorMessage = "Требуется ввести макс. количество участников")]
        public int Max_num_of_participants { get => max_num_of_participants; set => max_num_of_participants = value; }
    }
}
