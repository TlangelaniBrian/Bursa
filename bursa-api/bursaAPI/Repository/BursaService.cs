using bursaAPI.Application.Profile;
using bursaAPI.Modals;
using bursaDAL;
using bursaDAL.Modals;
using System.Collections.ObjectModel;

namespace bursaAPI.Repository
{
    public class BursaService(BursaContext bursaContext) : IBursaService
    {
        private BursaContext BursaContext { get; } = bursaContext;

        public Task<int> AddStudentUser(User student)
        {
            BursaContext.Add(student);
            return BursaContext.SaveChangesAsync();
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
