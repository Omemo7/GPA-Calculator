using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BCrypt.Net;

namespace GPACalculatorBusiness
{
    public class clsPasswordHasher
    {

        // Method to hash a password
        public static string HashPassword(string password)
        {
            // Hash the password; BCrypt automatically generates a salt
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Method to verify a password against a stored hash
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Verify the password and hash
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }





    }
}
