using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using $safeprojectname$.Models.Data;


namespace $safeprojectname$.Models
{
    public class Person
    {
        private string dept;
        private string email;
        private List<string> errors;
        private string firstName;
        private string id;
        private string lastName;
        private string phone;
        private string username;

        public string Dept {
            get { return this.dept; }
            set { this.dept = value; }
        }

        public string Email {
            get { return this.email; }
            set { this.email = value; }
        }

        public List<string> Errors {
            get { return this.errors; }
            set { this.errors = value; }
        }

        public string FirstName {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string FullName {
            get { return this.firstName + " " + this.lastName; }
        }


        public string ID {
            get { return this.id; }
            set { this.id = value; }
        }

        public string LastName {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string Phone {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public string Username {
            get { return this.username; }
            set { this.username = value; }
        }
           
        public Person() {
            this.Errors = new List<string>();
        }

        public Person(string userId) {
            PersonData pd = new PersonData();
            Person p = pd.GetPerson(userId);
            this.Dept = p.Dept;
            this.Email = p.Email;
            this.FirstName = p.FirstName;
            this.ID = p.ID;
            this.LastName = p.LastName;
            this.Phone = p.Phone;
            this.Username = p.Username;
        
        }
    }
}