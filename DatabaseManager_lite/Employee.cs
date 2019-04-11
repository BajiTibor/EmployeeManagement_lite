using System;

namespace DatabaseManager_lite
{
    public class Employee
    {
        private readonly CorrectDate _dateCorrection = new CorrectDate();
        public Employee(string id, string name, DateTime birthDate, string phone, string education, string profession,
            string state)
        { 
            Id = id;
            Name = name;
            BirthDate = _dateCorrection.CorrectDateTime(birthDate);
            Phone = phone;
            Education = education;
            Profession = profession;
            State = state;
        }

        public string Id { get; }
        public string Name { get; }
        public string BirthDate { get; }
        public string Phone { get; }
        public string Education { get; }
        public string Profession { get; }
        public string State { get; }

    }
}