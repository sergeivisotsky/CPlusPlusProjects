using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDataManager_DotNET_app.db
{
    interface IStudentDao
    {
        void AddRecord(Student student);
        List<Student> RetrieveData();
        List<Student> FindByPosition(string position);
        Student FindById(long id);
        void DeleteData(long id);
    }
}
