using BOL;
using MySql.Data.MySqlClient;
public class DBManeger{
   
       public class DBManeger(){}

       public List<Student> GetAll(){

        List<Student> students = new List<Student>();

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString =@"server=localhost; port=3306; user=root; password=Himanshu; database=dotnet";
        MySqlCommand cmd = new MySqlCommand();

        cmd.Connection=con;

        cmd.CommandText = "SELECT * from students";

        try{
              con.Open();
              MySqlDataReadre reader = cmd.ExecuteReader();

              while(reader.Read()){
                     int prn =int.Parse(reader["Prn"].ToString());
                     int rollNo =int.Parse(reader["RollNo"].ToString());
                     string? firstName=reader["FirstName"].ToString();
                     string? lastName=reader["LastName"].ToString();
                     string? courseId=reader["CourseId"].ToString();
                     string? email=reader["Email"].ToString();
                     string? adharNo=reader["AdharNo"].ToString();
                     string? address=reader["Address"].ToString();

                     Student std = new Student();

                     std.Prn = prn;
                     std.RollNo=rollNo;
                     std.FirstName=firstName;
                     std.LastName = lastName;
                     std.CourseId=courseId;
                     std.AdharNo=adharNo;
                     std.Address =address;
                     std.Email=email;
                     
                     students.Add(std);

              }

        }
        catch(Exception e){
              Console.WriteLine(e.Message);
        }
        finally{
              con.Close();
        }
           return students;
       }


       public Student GetById(int id){
              return new Student();
       }
}