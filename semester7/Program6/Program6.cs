using System;
using System.Xml;

namespace semester7.Program6
{
    public class Program6:IRunner
    {
        public void Run(string[] args)
        {
            UserList userList = new UserList();

            UserList.User user = new UserList.User();
            Console.WriteLine("Enter name");
            user.Name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            user.SetAge(Convert.ToInt32(Console.ReadLine()));



//            XmlDocument doc = new XmlDocument( );
//
//            //(1) the xml declaration is recommended, but not mandatory
////            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration( "1.0", "UTF-8", null );
////            XmlElement root = doc.DocumentElement;
////            doc.InsertBefore( xmlDeclaration, root );
//
//            XmlElement element1 = doc.CreateElement( string.Empty, "userNameList", string.Empty );
//            doc.AppendChild( element1 );
//
//            doc.Save("doucment.xml");

        }
    }
}