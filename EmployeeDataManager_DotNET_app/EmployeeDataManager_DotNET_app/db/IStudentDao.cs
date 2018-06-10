using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDataManager_DotNET_app.db
{
    interface IStudentDao
    {
        void AddRecord(Student student);
        void DisplayData();
        void DeleteData(long id);
    }
}
