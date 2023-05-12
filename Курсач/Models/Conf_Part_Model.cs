using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.Models
{
    public class Conf_Part_Model
    {
        private string conf_id;
        private int part_id;
        private string topic;

        [DisplayName("ID конференции")]
        [Required(ErrorMessage = "Требуется ID конференции")]
        public string Conf_id { get => conf_id; set => conf_id = value; }

        [DisplayName("ID участника")]
        public int Part_id { get => part_id; set => part_id = value; }

        [DisplayName("Тема доклада")]
        [Required(ErrorMessage = "Требуется тема доклада")]
        public string Topic { get => topic; set => topic = value; }
        
    }
}
