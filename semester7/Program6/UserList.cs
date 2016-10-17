using System;
using System.Collections;
using System.Text;
using System.Xml;

namespace semester7.Program6
{
    public class UserList
    {
        private ArrayList _users = new ArrayList();



        public void AddNewUser(User user)
        {
            this._users.Add(user);
        }

        public class User
        {
            public string Name;
            public int Age;


            public User(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public User()
            {

            }

            public void SetName(string name)
            {
                this.Name = name;
            }


            public void SetAge(int age)
            {
                this.Age = age;
            }


//            public XmlDocument GetXml()
//            {
//                XmlDocument document = new XmlDocument();
//                XmlElement user = document.CreateElement("user");
//                XmlElement nameElement = document.CreateElement("name");
//
//                XmlText name = document.CreateTextNode(this.Name);
//                nameElement.AppendChild(name);
//
//                XmlElement ageElement = document.CreateElement("age");
//
//                XmlText age = document.CreateTextNode(this.Age.ToString());
//                nameElement.AppendChild(name);
//
////                Console.WriteLine(Beautify(document));
//                return document;
//            }
//
//             public string Beautify(XmlDocument doc)
//            {
//                StringBuilder sb = new StringBuilder();
//                XmlWriterSettings settings = new XmlWriterSettings
//                {
//                    Indent = true,
//                    IndentChars = "  ",
//                    NewLineChars = "\r\n",
//                    NewLineHandling = NewLineHandling.Replace
//                };
//                using (XmlWriter writer = XmlWriter.Create(sb, settings)) {
//                    doc.Save(writer);
//                }
//                return sb.ToString();
//            }

        }
    }
}