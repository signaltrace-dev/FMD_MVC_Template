using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FMD.User;
using FMD.User.Authentication;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace $safeprojectname$.Models
{
    public class LoginUser
    {
        private string firstName;
        private bool isAuthenticated;
        private string lastName;
        private string password;
        private string userId;
        private string userName;

        public string FirstName {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string FullName {
            get { 
                if(!string.IsNullOrEmpty(this.firstName) && !string.IsNullOrEmpty(this.LastName))
                {return this.firstName + " " + this.lastName; }
                
                return string.Empty;
            }
        }

        public bool IsAuthenticated {
            get { return this.isAuthenticated; }
            set { this.isAuthenticated = value; }
        }

        public string LastName {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        [DisplayName("Password")]
        public string Password {
            get { return this.password; }
            set { this.password = value; }
        }

        public string UserID {
            get { return this.userId; }
            set { this.userId = value; }
        }

        [DisplayName("MyID")]
        public string UserName {
            get { return this.userName; }
            set { this.userName = value; }
        }

        public LoginUser(){

        }

        public void Authenticate() {
            MyIDAuthenticator auth = new MyIDAuthenticator();
            FMD.User.User u = auth.AuthenticateUser(this.UserName, this.password);
          
            if (u.IsValid) {
                this.UserID = u.UserID;
                this.IsAuthenticated = true;
                this.SetNameInfo();
            }

            this.password = string.Empty;
        }

        private void SetNameInfo() {
            Data.PersonData pd = new Data.PersonData();
            Person p = pd.GetPerson(this.UserID);

            this.FirstName = p.FirstName;
            this.LastName = p.LastName;
        }
    }
}