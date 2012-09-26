using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Collections;

namespace MyResumeWcfRestService
{
    public class XMLParsers
    {
        private static string filePath = @"C:\C#\MyResumeWcfRestService\MyResumeWcfRestService\resume.xml";
        private static Resume resume;

        public Resume RESUME
        {
            get { return resume; }
        }

        public XMLParsers(string inputFilePath = @"C:\C#\MyResumeWcfRestService\MyResumeWcfRestService\resume.xml")
        {
            if (inputFilePath == String.Empty || inputFilePath == null)
                throw new ArgumentNullException("Please provide full pathname to the xml resume file.  Eg. C:\\resume.xml");

            filePath = inputFilePath;
        }

        public Resume ParseByInputFile()
        {
            resume = new Resume();
            resume.Educations = new List<Education>();
            resume.Experiences = new List<Experience>();

            XmlDocument resumeData = new XmlDocument();
            resumeData.Load(filePath);

            XmlNode resumeDetail = resumeData.SelectSingleNode("/Resume");
            resume.FullName = resumeDetail.SelectSingleNode("FullName").InnerText;
            resume.AddressLine1 = resumeDetail.SelectSingleNode("AddressLine1").InnerText;
            resume.AddressLine2 = resumeDetail.SelectSingleNode("AddressLine2").InnerText;
            resume.City = resumeDetail.SelectSingleNode("City").InnerText;
            resume.State = resumeDetail.SelectSingleNode("State").InnerText;
            resume.PostalCode = resumeDetail.SelectSingleNode("PostalCode").InnerText;

            XmlNode Educations = resumeDetail.SelectSingleNode("Educations");
            XmlNodeList InstitutionList = Educations.SelectNodes("Institution");
            foreach (XmlNode node in InstitutionList)
            {
                var temp = new Education();
                temp.Institution = node.InnerText;
                temp.Degree = node.SelectSingleNode("Degree").InnerText;
                temp.Major = node.SelectSingleNode("Major").InnerText;
                temp.GraduatedMonth = node.SelectSingleNode("GraduatedMonth").InnerText;
                temp.GraduatedYear = node.SelectSingleNode("GraduatedYear").InnerText;

                resume.Educations.Add(temp);
            }

            XmlNode Experiences = resumeDetail.SelectSingleNode("Experiences");
            XmlNodeList ExperienceList = Experiences.SelectNodes("companyName");
            foreach (XmlNode node in ExperienceList)
            {
                Experience exp = new Experience();
                exp.CompanyName = node.InnerText;
                exp.JobTitle = node.SelectSingleNode("jobTitle").InnerText;
                exp.FromYear = node.SelectSingleNode("fromYear").InnerText;
                exp.ToYear = node.SelectSingleNode("toYear").InnerText;
                exp.JobDescriptions = node.SelectSingleNode("jobDescriptions").InnerText;

                resume.Experiences.Add(exp);
            }

            return resume;
        }

    }
}