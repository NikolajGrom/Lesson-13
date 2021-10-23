using System.Collections.Generic;

 public class RemoveReplays : IEqualityComparer<User>
  {
        public bool Equals(User x, User y)
        {
          if(x.Passvord != y.Passvord)
          return false;
          return true;
        }
        public int GetHashCode(User bx)
        {
            int hCode = bx.Login.Length + bx.Passvord;
            return hCode.GetHashCode();
        }
    
    }