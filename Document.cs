using System;
using System.IO;

namespace DocumentApplication{

  class Document{

    static void main(strings[]args){
      
      try{
           Console.WriteLine("Document");
           Console.WriteLine("Enter Document Title:");
           string name=Console.ReadLine();
           Console.WriteLine("Enter Document Content:");
           string content=Console.ReadLine();
           string filename=name+".txt";
           string path= Environment.CurrentDirectory+"/"+filename;
           
           if(!File.Exists(path))
           {
              File.WriteAllText(path,content);
           }
           
           {
              Console.WriteLine(filename+"was successfully saved. The document contains "+content.Length+"characters");
           }
           
           catch(Exception e);
           {
           Console.WriteLine(e);
           }
           }
           }
    
 
