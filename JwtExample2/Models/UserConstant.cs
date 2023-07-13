namespace JwtExample2.Models
{
    public class UserConstant
    {
        public static List<UserModel> Users = new()
        {
            new UserModel { UserName = "TeodoraSiljanoska", Password = "teodora123", Role = "Admin" },
            new UserModel { UserName = "AnaAnevska", Password = "ana12345678", Role = "User" },
            new UserModel { UserName = "JaneJanevski", Password = "jane12345678", Role = "User" }



        };
    }
}
