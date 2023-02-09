
namespace Excersise_4._1
{
    internal class Candidate
    {
        public Person personInfo;
        public SubjectScore[] subjectScore;

        public Candidate(Person person, SubjectScore[] score)
        {
            personInfo = person;
            subjectScore = score;
        }
    }
}
