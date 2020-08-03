using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Windows.Forms;

namespace SOLID.Single_resp
{
   public class UserService
   {
       public UserService()
        {

        }
        /// <summary>
        /// The method which is exposed to outside
        /// </summary>
        public bool RegisterUser(User user)
        {
            if (ValidUser())
            {
                SaveUserToDb();
                return true;
            }

            return false;
        }

        private void SaveUserToDb() //Violates the single responsibility 
        {
       //logic to save the user to the Database
        }

        /// <summary>
        /// To validate the user name and password
        /// </summary>
        /// <returns></returns>
        private bool ValidUser()  //Violates the single responsibility of the class
        {
         //logic to validate the user
         return true;
        }
   }


    //Refactored Code
    public class UserServiceRefactored
    {
        private IValidateUser _validateUser;
        private IDbContext _userDbContext;
        public UserServiceRefactored(IValidateUser validateUser,IDbContext userDbContext)
        {
            //injecting the dependencies through constructor
            _validateUser = validateUser;
            _userDbContext = userDbContext;

        }
        /// <summary>
        /// The method which is exposed to outside
        /// </summary>
        public bool RegisterUser(User user)
        {
            if (_validateUser.IsValidUserName())
            {
                _userDbContext.SaveToDb();
                return true;
            }

            return false;
        }
    }


    public class ValidateUser:IValidateUser
    {
        public bool IsValidUserName()
        {
            //logic to validate user name
            return true;
        }
    }

    public class UserDbContext:IDbContext
    {
        public void SaveToDb()
        {
            //implementation of save to db logic
        }
    }

    public interface IValidateUser
    {
        bool IsValidUserName();
    }

    public interface IDbContext
    {
        void SaveToDb();
    }

    public class ClientCode
    {
        //create user
        public void Main()
        {
            var user=new User(){Name = "Ashin",Password = "mypass"};
            //Register user
            IValidateUser userValidation=new ValidateUser();
            IDbContext userDbContext=new UserDbContext();
            var userService =new UserServiceRefactored(userValidation,userDbContext);
            if (userService.RegisterUser(user))
            {
                MessageBox.Show("User Succesfully Registered");
            }
   

        }
    }
}
