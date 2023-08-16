namespace Jokes_App_MVC.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        //this is a constructor
        public Joke()
        {
                
        }

    }
}
