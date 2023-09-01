using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using _01._09_lb.Model;

namespace _01._09_lb.Controller
{
    internal class PersonControl
    {
        Person obj;

        public PersonControl() { obj = new Person(); }
        public PersonControl(Person person) {
            obj = new Person();
            obj.Name = person.Name;
            obj.Surname = person.Surname;
            obj.Patronymic = person.Patronymic;
            obj.BirhDate = person.BirhDate;
            obj.Sex = person.Sex;
            obj.MartialSt = person.MartialSt;
            obj.PersonalInfo = person.PersonalInfo;

        }

        public void SaveInfo()
        {
            using (var stream = new FileStream(obj.Name + "_" + obj.Surname + ".xml",FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(Person));
                serializer.Serialize(stream, obj);
            }
        }
        public Person LoadInfo(string path)
        {
            try
            {
                using (var stream = new FileStream(path, FileMode.Open))
                {
                    var serializer = new XmlSerializer(typeof(Person));
                    return (Person)serializer.Deserialize(stream);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            return null;
        }
    }
}
