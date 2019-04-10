using System.Collections.Generic;

namespace DatabaseManager_lite
{
    public class NewEmployeeCheck
    { // Ellenőrzi azt, hogy a dolgozó objektumnak megfelelő változókat adtunk e vagy sem.
        public bool CheckEmployee(Employee employee)
        {
            var employeeInfo = new List<string>
            {
                employee.Name,
                employee.BirthDate,
                employee.Phone,
                employee.Education,
                employee.Profession,
                employee.State,
            };

            for (int i = 0; i < employeeInfo.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(employeeInfo[i]) || employeeInfo[i].Contains(";"))
                {
                    return false;
                } // Nem lehet benne pontosvessző, hiszen ezzel tudnánk lezárni egy SQL kifejezést.
            }
            
            return true;

        }
    }
}