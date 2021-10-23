using System.Collections.Generic;
public class UserEqualityComparer_All : IEqualityComparer<User>
    {
        public bool Equals(User b1, User b2)
        {
            if(b1.Age != b2.Age)
                return false;
            if(b1.RegistrationDate != b2.RegistrationDate)
                return false;
            if(b1.Login != b2.Login)
                return false;
            if(b1.Passvord != b2.Passvord)
                return false;

            return true;
        }

        public int GetHashCode(User bx)
        {
            int hCode = bx.Login.Length + bx.Passvord;
            return hCode.GetHashCode();
        }

        
    }