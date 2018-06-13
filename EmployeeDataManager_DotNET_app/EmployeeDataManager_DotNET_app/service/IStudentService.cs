using System;
using System.Collections.Generic;
using System.Text;
using EmployeeDataManager_DotNET_app.db;

namespace EmployeeDataManager_DotNET_app.service
{
    interface IStudentService
    {
        void AddRecord();
        void RetrieveData();
        void FindByPositionService();
        void FindByIdService();
        Student FindById();
        void DeleteData();
    }
}
