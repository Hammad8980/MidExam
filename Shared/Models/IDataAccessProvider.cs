using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidExam.Shared.Models
{
    public interface IDataAccessProvider
    {
        void AddClientRecord(Persons person);
        void UpdateClientRecord(Persons person);
        void DeleteClientRecord(int id);
        Persons GetClientRecord(int id);
        List<Persons> GetClientRecord();
    }
}
