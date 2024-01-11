using BOL;
using DAL;
namespace BLL;

public class BIManager
{

    public List<Student> GetAll(){
        MySqlDBManager mgr=new MySqlDBManager();
        List<Student> students=mgr.GetAll();
        //LINQ
        return students;
    }

    public  Student GetById(int id){
        MySqlDBManager mgr=new MySqlDBManager();
        Student student=mgr.GetById(id);
        return student;
    }

}
