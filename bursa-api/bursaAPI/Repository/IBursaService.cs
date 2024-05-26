using bursaAPI.Application.Profile;
using bursaAPI.Modals;
using bursaDAL.Modals;
using System.Collections.ObjectModel;

namespace bursaAPI.Repository
{
    public interface IBursaService
    {
        #region------ Delete Methods ------

        public Task<int> DeleteBursaries(Collection<BursaryId> bursaryIds);
        #endregion

        #region------ Select Methods ------

        public (Student Student, CorpBursary Bursary) GetStudentCorpBursay(int dealerId);

        public IQueryable<Student> GetStudentsId(Collection<UserId> studentIds);
        public CorpBursary GetCorpBursary(BursaryId bursaryId);
        #endregion

        #region------ Add Methods ------
        public Task<int> AddStudentUser(User student);
        #endregion

        #region------ Update Methods ------

        public Task<int> UpdateStudent(Student student);

        #endregion

    }
}
