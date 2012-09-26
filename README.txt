README

There are two project files in this folder:
1. MyResumeWcfRestService is the REST webservice (coding question) that I was asked to do. 
For this project, I only implement one API which is WebGet().  The AIP is GetCollection().

2. ConsoleTestWcfRESTWebServices was created to test the ResumeWebService (the above project) using HTTPWebResponse.
The test simply print out HTTPWebResponse body on the console.  

MyResumeWcfRestService project is implemented in .Net Framework 4.0 using ‘WCFRESTservice’ template. 
Web services API returns Resume object which contains collections for ‘Educations’, ‘Experiences’, and etc…
Resume class contains FullName, Address, Phone, Educations (collections), and Experiences (collections)…  
At this point, I had decided to read the resume data from resume.xml files and send the data out to the web frontend via REST API (GetCollection())…  A utility class (XMLParsers) is created for parsing in the input from resume.xml file.  

For simplicity, I have designed the XMLParsers class to accept the location of the input file (resume.xml). 
However, due to the fact that I want to make this project as simple and small as possible, I have added the resume.xml to the project file folder.  When you want to run the project, you will have to open the project file and provide the full path to the resume.xml in ResumeService.cs/GetCollection() function. 

The current implementation (due to time limitation) is as follows:
        [WebGet(UriTemplate = "")]
        public List<Resume> GetCollection()
        {
            XMLParsers xmlParsers = new XMLParsers(@"C:\C#\MyResumeWcfRestService\MyResumeWcfRestService\resume.xml");
            Resume myresume = xmlParsers.ParseByInputFile();

            return new List<Resume>() { myresume };
        }

Please note the path to the resume.xml in the code above.  This is where you will need to change.  Also note that I only put in a few lines of Experiences (for shortness of the resume.xml file).  
Although the data is sent across in XML format (in the body of the HTTPWebResponse), the page does not has frontend UI.  The following is the endpoint:  http://localhost:53581/ResumeService/ 

If you have any question(s), please feel free to contact me. 
