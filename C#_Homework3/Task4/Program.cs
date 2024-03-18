string email = "somemail@gmail.com";
string falseemail = "so.mem@ail@gmail.com.";
string idk = "skdjghfkgjhgjkhngbfdkjg";
string bonelessEmail = "@yahoo.com";

string hwExample = "@gmail.com";
string hwExample2 = "hello.gmail@com";
string hwExample3 = "gmail";
string hwExample4 = "hello@gmail.com";


int found = 0;

void EmailFunction(string input)
{
string[] scrubArray = {"@gmail.com", "@yahoo.com", "@hotmail.com", "@mail.com" };

    foreach (string scrub in scrubArray)
    {
        if (input.IndexOf(scrub) != -1)
        {
            string substring = input.Substring(0, input.IndexOf(scrub));
            if(substring == "")
            {

            }
            else
            {
                found = 1;
                Console.WriteLine($"The email {input} is valid");
                break;
            }
          
        }
        else
        {

        }
    }

    if(found == 0)
    {
        Console.WriteLine($"The email {input} is invalid");
    }
    else
    {
        found = 0;
    }
   
}

EmailFunction(email);
EmailFunction(falseemail);
EmailFunction(idk);
EmailFunction(bonelessEmail);

EmailFunction(hwExample);
EmailFunction(hwExample2);
EmailFunction(hwExample3);
EmailFunction(hwExample4);

//Sad to say this is the best I could think of :(((((