
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;




public interface ISqlDataAccess
{
Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default");
 Task SaveData<T>(string storedProcedure,T parameters, string connectionId = "Default");


}
