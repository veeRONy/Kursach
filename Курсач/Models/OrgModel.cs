using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.Models
{
    public class OrgModel
    {
        // поля из бд
        private int org_id;
        private string org_surname;
        private string org_name;
        private string org_company;
        private string org_email;
        private int conf_id;

        [DisplayName("ID")]
        public int Org_id { get => org_id; set => org_id = value; }

        [DisplayName("Фамилия")]
        [Required(ErrorMessage = "Требуется фамилия")]
        public string Org_surname { get => org_surname; set => org_surname = value; }

        [DisplayName("Имя")]
        [Required(ErrorMessage = "Требуется имя")]
        public string Org_name { get => org_name; set => org_name = value; }

        [DisplayName("Организация")]
        [Required(ErrorMessage = "Требуется организация")]
        public string Org_company { get => org_company; set => org_company = value; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Требуется e-mail")]
        public string Org_email { get => org_email; set => org_email = value; }

        [DisplayName("ID конференции")]
        public int Conf_id { get => conf_id; set => conf_id = value; }
    }
}
