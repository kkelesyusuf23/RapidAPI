namespace RapidAPI.Models
{
    public class LinkedinViewModel
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool isOpenToWork { get; set; }
        public bool isHiring { get; set; }
        public string profilePicture { get; set; }
        public string summary { get; set; }
        public string headline { get; set; }
        public Geo geo { get; set; }
        public object languages { get; set; }
        public Education[] educations { get; set; }
        public Position[] position { get; set; }
        public Skill[] skills { get; set; }
        public object givenRecommendation { get; set; }
        public object receivedRecommendation { get; set; }
        public object courses { get; set; }
        public Certification[] certifications { get; set; }

        public class Geo
        {
            public string country { get; set; }
            public string city { get; set; }
            public string full { get; set; }
        }

        public class Education
        {
            public Start start { get; set; }
            public End end { get; set; }
            public string fieldOfStudy { get; set; }
            public string degree { get; set; }
            public string grade { get; set; }
            public string schoolName { get; set; }
            public string description { get; set; }
            public string activities { get; set; }
        }

        public class Start
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class End
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class Position
        {
            public string companyName { get; set; }
            public string companyUsername { get; set; }
            public string companyURL { get; set; }
            public string companyIndustry { get; set; }
            public string companyStaffCountRange { get; set; }
            public string title { get; set; }
            public string location { get; set; }
            public string description { get; set; }
            public string employmentType { get; set; }
            public Start1 start { get; set; }
            public End1 end { get; set; }
        }

        public class Start1
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class End1
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class Skill
        {
            public string name { get; set; }
        }

        public class Certification
        {
            public string name { get; set; }
            public Start2 start { get; set; }
            public End2 end { get; set; }
            public string authority { get; set; }
            public Company company { get; set; }
            public Timeperiod timePeriod { get; set; }
        }

        public class Start2
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class End2
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class Company
        {
            public Staffcountrange staffCountRange { get; set; }
            public Headquarter headquarter { get; set; }
        }

        public class Staffcountrange
        {
        }

        public class Headquarter
        {
        }

        public class Timeperiod
        {
            public Start3 start { get; set; }
            public End3 end { get; set; }
        }

        public class Start3
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class End3
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }


    }
}
