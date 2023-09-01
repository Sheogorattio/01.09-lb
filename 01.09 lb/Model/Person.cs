using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01._09_lb;

namespace _01._09_lb.Model
{
    [Serializable]
    public class Person
    {
        public Person() { 
        }
        public Person(string name, string surname, string patronymic, string sex, DateTime birth, string martialSt, string personalInfo)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Sex = sex;
            BirhDate = birth;
            MartialSt = martialSt;
            PersonalInfo = personalInfo;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Sex { get; set; }
        public DateTime BirhDate { get; set; }
        public string MartialSt { get; set; }
        public string PersonalInfo { get; set; }
    }
}
