

using System.ComponentModel.DataAnnotations;

namespace VseTShirts.Models
{
    public class Order
    {
        private static int idNumerator = 0;
        public int Id { get; set; }

        public User User { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [MinLength(2, ErrorMessage = "Имя слишком короткое")]
        public string Name {  get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [MinLength(15, ErrorMessage = "Адресс слишком короткий")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [MinLength(9, ErrorMessage = "Номер слишком короткий")]
        public string Phone { get; set; }
        public OrderStatus Status { get; set; }

        public DateTime DateAndTime { get; set; }

        public Cart Cart { get; set; }
        public Order ()
        {
            Id = idNumerator++;
            DateAndTime = DateTime.Now;
            Status = OrderStatus.Создан;
        }
    }
}

public enum OrderStatus
{
    Создан, Удален, Одобрен, ВДоставке, ОжидаетОплату, ОжидаетПолучение, Получен
}
