using System.Xml.Serialization;

namespace SeriliazationDemo
{

    public class Program
    {

        public static void Main()
        {
            JosnSerialize.SerlizeJson();

        }
    }
}

//Seriliazation -->
//converting a DATASTRUCTURE or OBJECT into a format that can be easily stored, transmitted, over network ,server to client 
//-->JSON, XML, or binary data.
//System.Text.Json --for json 

//Preferred alternatives for Binary Formater
    //XmlSerializer and DataContractSerializer to serialize object graphs into and from XML. Do not confuse DataContractSerializer with NetDataContractSerializer.
    //BinaryReader and BinaryWriter for XML and JSON.
    //The System.Text.Json APIs to serialize object graphs into JSON.