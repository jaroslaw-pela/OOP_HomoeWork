using Infoshare.HandsOn.Csv.Enums;

namespace Infoshare.HandsOn.Csv.Data
{
    public class User
    {
        public int Id { get; set; }

        public string Name{ get; set; }

        public string Surname { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public bool IsVip { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
