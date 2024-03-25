using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    class User
    {
        static public List<User> Users = new List<User>();
        string Name { get; set; }
        string SubName { get; set; }
        int Age { get; set; }
        int Number { get; set; }
        string Birghtday { get; set; }
        public User(string _name,string _subName, int _age,int _number,string _birghtday)
        {
            Name = _name;
            SubName = _subName;
            Age = _age;
            Number = _number;
            Birghtday = _birghtday;
        }
        public string Show()
        {
            return $"Имя: {Name}\nФамилия: {SubName}\nВозраст: {Age}\nНомер телефона: {Number}\nДень рождения: {Birghtday}";
        }
    }
}
