using System;
using System.Xml;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CourseWork
{
    public class Student
    {
        private string _filePath = "Student.json";

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Contact { get; set; }
        public string Gender { get; set; }
        public string Faculty { get; set; }
        public DateTime RegistrationDate { get; set; }

        public void Add(Student info)
        {
            Random r = new Random();
            info.Id = r.Next(1000, 9999);
            string data = JsonConvert.SerializeObject(info, Newtonsoft.Json.Formatting.None);
            Utility.WriteToTextFile(_filePath, data);

        }

        public List<Student> List()
        {
            string d = Utility.ReadFromTextFile(_filePath);
            if (d != null)
            {
                List<Student> lst = JsonConvert.DeserializeObject<List<Student>>(d);
                return lst;
            }
            return null;
        }
        public void Edit(Student info)
        {
            //invoking list method of the student class to get student list
            List<Student> list = List();
            //using linq to select student having the specified id
            Student s = list.Where(x => x.Id == info.Id).FirstOrDefault();
            //removing  student object that is to be updated from the list
            list.Remove(s);
            //adding the updated student object to the list
            list.Add(info);
            //converting list of student to string
            string data = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.None);
            //invoking method of utility class 
            Utility.WriteToTextFile(_filePath, data, false);
        }
        public void Delete(int id)
        {
            List<Student> list = List();
            Student s = list.Where(x => x.Id == id).FirstOrDefault();
            list.Remove(s);
            string data = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.None);
            Utility.WriteToTextFile(_filePath, data, false);
        }
    }
}