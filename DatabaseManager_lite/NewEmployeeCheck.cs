using System.Collections.Generic;

namespace DatabaseManager_lite
{
    public class NewEmployeeCheck
    {
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
                }
            }
            
            return true;

        }
    }
}