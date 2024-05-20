using bursaAPI.Modals;
using bursaDAL.Modals;
using System.Collections.ObjectModel;

namespace bursaAPI.Repository
{
    public class BursaService : IBursaService
    {
        public Task<int> AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteBursaries(Collection<BursaryId> bursaryIds)
        {
            throw new NotImplementedException();
        }

        public CorpBursary GetCorpBursary(BursaryId bursaryId)
        {
            throw new NotImplementedException();
        }

        public (Student Student, CorpBursary Bursary) GetStudentCorpBursay(int dealerId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Student> GetStudentsId(Collection<UserId> studentIds)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
