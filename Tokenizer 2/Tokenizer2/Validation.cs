using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tokenizer_2
{
    class Validation
    { 
        public static string ValidateClientKey(string clientkey)
        {
        string result = String.Empty;
        if (clientkey == String.Empty)
        {
            result = "Client Key field is empty!";
            return result;
        }
        int parsedClientKey;
        if (!Int32.TryParse(clientkey, out parsedClientKey)) {
            if (parsedClientKey <= 0)
            {
                result = "Client Key not formatted correctly!";
                return result;
            }
        }
        return result;
        }

        public static string ValidateUserName(string userName)
        {
            string result = String.Empty;
            if (userName == String.Empty)
            {
                result = "Username field is empty!";
                return result;
               
            }
            return result;
        }

        public static string ValidateCountry(string country)
        {
            string result = String.Empty;
            if (country == String.Empty)
            {
                result = "Please select a country!";
                return result;

            }
            return result;
        }
    }
}
