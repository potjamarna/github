using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MyResumeWcfRestService
{
    public class Resume
    {
        private string fullName;
        private string addressLine1;
        private string addressLine2;
        private string city;
        private string state;
        private string postalCode;

        private List<Education> educations;
        private List<Experience> experiences;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }

        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public List<Education> Educations
        {
            get { return educations; }
            set { educations = value; }
        }

        public List<Experience> Experiences
        {
            get { return experiences; }
            set { experiences = value; }
        }

        //filling in methods

    }

    public class Education
    {
        private string graduatedMonth;
        private string graduatedYear;
        private string degree;
        private string major;
        private string minor;
        private string institution;

        public string GraduatedMonth
        {
            get { return graduatedMonth; }
            set { graduatedMonth = value; }
        }

        public string GraduatedYear
        {
            get { return graduatedYear; }
            set { graduatedYear = value; }
        }

        public string Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public string Minor
        {
            get { return minor; }
            set { minor = value; }
        }

        public string Institution
        {
            get { return institution; }
            set { institution = value; }
        }

        //filling in methods
    }

    public class Experience
    {
        private string fromYear;
        private string toYear;
        private string companyName;
        private string jobTitle;
        private string jobDescriptions;

        public string FromYear
        {
            get { return fromYear; }
            set { fromYear = value; }
        }

        public string ToYear
        {
            get { return toYear; }
            set { toYear = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public string JobDescriptions
        {
            get { return jobDescriptions; }
            set { jobDescriptions = value; }
        }

        //filling in methods

    }
}