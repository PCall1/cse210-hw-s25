using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        library.UserChoice();
    }
}

///For the stretch I added a simple format to the display 
/// method in the scripture class so that the words are 
/// always displayed with a maximum length of 60 characters 
/// per line. This makes it slightly more like reading the 
/// actual scriptures and easier to read.