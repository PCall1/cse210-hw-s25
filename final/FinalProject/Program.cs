using System;

/// <summary>
/// I have a project with most things working well. I have written basic code for each 
/// class and it's enough to function. The program class is not finished yet, but it
/// does have most of what it needs. It can create contacts, create groups, view groups, 
/// and search for contacts. I've done my best to have code in classes be relevant to only 
/// the class itself, to follow the idea of encapsulation, along with private attributes
/// as often as possible; though I do have a few protected attributes where relevant. I've 
/// got the contact class coded with child classes inheriting from it certain attributes and 
/// methods. Meanwhile, most code is in the child classes because they store unique information.
/// This will mostly match my class diagram, however, as I coded it, I realized several 
/// methods that could be rearranged or removed, and some to be added; so it will be different.
/// I also made a number of errors in the class diagram which are fixed in the program. I 
/// haven't added abilities to edit contacts or groups, I would also like to add the ability to 
/// save to a file, and load from it. I also learned about how to make ui a little but more friendly
/// with "press enter to continue" functionality.
/// </summary>


class Program
{
    static void Main(string[] args)
    {
        ContactManager manager = new ContactManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Contact Manager");
            Console.WriteLine("1) Create Contact");
            Console.WriteLine("2) Search Contact");
            Console.WriteLine("3) View Groups");
            Console.WriteLine("4) Create Group");
            //Console.WriteLine("5) Edit Contact");
            Console.WriteLine("x) Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateContact(manager);
                    break;
                case "2":
                    SearchContact(manager);
                    break;
                case "3":
                    ViewGroups(manager);
                    break;
                case "4":
                    CreateGroup(manager);
                    break;
                case "x":
                    running = false;
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter a valid option");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void CreateContact(ContactManager manager)
    {
        // Prompt for contact type and info, then add to manager
        Console.WriteLine("Select contact type:");
        Console.WriteLine("1) Family Member");
        Console.WriteLine("2) Coworker");
        Console.WriteLine("3) SchoolMate");
        Console.WriteLine("4) Dating Prospect");
        Console.Write("Choice: ");
        string type = Console.ReadLine();

        if (type != "1" && type != "2" && type != "3" && type != "4")
        {
            Console.WriteLine("Invalid contact type. Please try again.");
            return;
        }

        // Gather PersonInfo
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Phone Number: ");
        string phone = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("Birthday (MM/DD/YYYY): ");
        DateTime birthday = DateTime.TryParse(Console.ReadLine(), out DateTime bday) ? bday : DateTime.MinValue;
        PersonInfo info = new PersonInfo(name, phone, email, address, birthday);

        Contact contact;
        switch (type)
        {
            case "1":
                Console.Write("Relationship: ");
                string relationship = Console.ReadLine();
                contact = new FamilyMember(info, relationship);
                break;
            case "2":
                Console.Write("Company: ");
                string company = Console.ReadLine();
                Console.Write("Job Position: ");
                string job = Console.ReadLine();
                contact = new Coworker(info, company, job);
                break;
            case "3":
                Console.Write("School Name: ");
                string school = Console.ReadLine();
                Console.Write("Major: ");
                string major = Console.ReadLine();
                Console.Write("Graduation Year: ");
                int gradYear = int.TryParse(Console.ReadLine(), out int gy) ? gy : 0;
                Console.Write("Mutual Classes: ");
                string mutualClasses = Console.ReadLine();
                contact = new SchoolMate(info, school, major, gradYear, mutualClasses);
                break;
            case "4":
                Console.Write("Mutual Interests: ");
                string interests = Console.ReadLine();
                Console.Write("Interest Level: ");
                string interestLevel = Console.ReadLine();
                Console.Write("Still Talking (true/false): ");
                bool stillTalking = bool.TryParse(Console.ReadLine(), out bool st) ? st : false;
                contact = new DatingProspect(info, interests, interestLevel, stillTalking);
                break;
            default:
                Console.WriteLine("Invalid contact type.");
                return;
        }

        manager.AddContact(contact);
        Console.WriteLine("Contact added! Press Enter to continue...");
        Console.ReadLine();
    }

    static void SearchContact(ContactManager manager)
    {
        Console.Write("Enter contact name to search: ");
        string name = Console.ReadLine();
        Contact contact = manager.FindContactByName(name);
        if (contact != null)
        {
            Console.WriteLine("Contact found:");
            Console.WriteLine(contact.GetContactDetails());
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void ViewGroups(ContactManager manager)
    {
        List<ContactGroup> groups = manager.GetAllGroups();
        if (groups.Count == 0)
        {
            Console.WriteLine("No groups available.");
        }
        else
        {
            foreach (ContactGroup group in groups)
            {
                Console.WriteLine(group.ListContacts());
            }
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void CreateGroup(ContactManager manager)
    {
        Console.Write("Enter group name: ");
        string groupName = Console.ReadLine();
        ContactGroup group = new ContactGroup(groupName);
        manager.AddGroup(group);
        Console.WriteLine($"Group '{groupName}' created! Press Enter to continue...");
        Console.ReadLine();
    }
}