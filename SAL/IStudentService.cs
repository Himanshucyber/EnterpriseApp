using BOL;

namespace SAL;

public interface IStudentService{
     public List<Student> GetAll();
    public Student GetById(int id);
    public void Insert(Student emp);
     public void Update(Student emp);
     public void Delete(int id);
}