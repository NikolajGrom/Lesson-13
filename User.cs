using System;
    public class User
    {
    public  string Login{get; set;}
    public int Passvord{get; set;}
    public string RegistrationDate {get; set;}
    public int Age {get; set;}



    public User(string Login,int Passvord,string RegistrationDate, int Age)
    {
        this.Login = Login;
        this.Passvord = Passvord;
        this.RegistrationDate = RegistrationDate;
        this.Age = Age;

        
    }
        public override string ToString()
        {
            return String.Format(" Login\t{0} Passvord\t{1} RegistrationDate\t{2} Age\t{3} ", this.Login, this.Passvord, this.RegistrationDate, this.Age  );
        }

    }
    