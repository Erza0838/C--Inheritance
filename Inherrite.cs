// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
  class Program
  { 
    static void Main(string[] arg)
    {   
      string[] namePerson = { "Muhammad erza", "Ryanto" };
      string[] personCareer = { "Programer", "Desainer grafis" };
      int[] AgePerson = { 19, 20 };

      // Buat object dan jalankan funciton untuk menampilkan data pada field
      InfoPerson PersonData = new InfoPerson();
      PersonData.InheritePersonName = namePerson[0]; 
      PersonData.InheritePersonAge = AgePerson[0];
      PersonData.ShowInforPerson(personCareer[0]);
      
      PersonData.InheritePersonName = namePerson[1]; 
      PersonData.InheritePersonAge = AgePerson[1];
      PersonData.ShowInforPerson(personCareer[1]);

    }
  }
}