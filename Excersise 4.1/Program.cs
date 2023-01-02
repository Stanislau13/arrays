
namespace Excersise_4._1
{
    internal class Program
    {
        public static readonly string[] Streets = { "Park Avenue", "Broadway", "St. Mark's Place", "Washington Street", "Wall Street" };
        public static readonly string[] FNames = {"Ben", "Doug", "John", "David", "Will"};
        public static readonly string[] LNames = {"Abbott", "Marcaida", "Neilson", "Baker", "Willis"};
        static void Main(string[] args)
        {
            Candidate[] candidates = {CreatCandidate(), CreatCandidate(), CreatCandidate(), CreatCandidate(), CreatCandidate()};
            int maxMathScore = 0;
            for (int i = 0; i < candidates.Length; i++)
            {
                Candidate candidate = candidates[i];
                string street = candidate.personInfo.PersonAddress.Street;
                
                int mathScore = 0;
                SubjectScore[] subjectScores = candidate.subjectScore;
                for (int j = 0; j < subjectScores.Length; j++) 
                {
                    SubjectScore subjectScore = subjectScores[j];
                    string subject = subjectScore.SubjectName;
                    if (subject == "Maths")
                    {
                        mathScore = subjectScore.Score;
                        if (mathScore > maxMathScore)
                        {
                            maxMathScore = mathScore;
                        }
                    }
                }
                Console.WriteLine($"{candidate.personInfo.FirstName} {candidate.personInfo.LastName} __ Maths: {mathScore} street: {street}");
            }
            Console.WriteLine($"max Math score is {maxMathScore}");

        }

        static Candidate CreatCandidate() 
        {
            Random rand = new Random();
            SubjectScore[] subjectScores = {    new SubjectScore(rand.Next(1, 100), "Maths"),
                                                new SubjectScore(rand.Next(1, 100), "Phisics"),
                                                new SubjectScore(rand.Next(1, 100), "Literature"),
                                                new SubjectScore(rand.Next(1, 100), "Language"),
                                                new SubjectScore(rand.Next(1, 100), "History")
                                            };

            string randomStreet = Streets[rand.Next(0, 4)];
            string randomFName = FNames[rand.Next(0, 4)];
            string randomLName = LNames[rand.Next(0, 4)];
            Address address = new Address("NY", randomStreet, rand.Next(1, 20), rand.Next(1, 200));

            Person person = new Person(randomFName, randomLName, address);


            return new Candidate(person, subjectScores);
        }
    }
}