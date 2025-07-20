using System;

/// <summary>
///
/// </summary>


class Program
{
    static void Main(string[] args)
    {
        const string saveFile = "contacts.json";
        ContactManager manager = ContactManager.LoadFromFile(saveFile);

        bool running = true;

        // add code to load contacts from a file before user interacts with program
        // this should be able to rebuild contacts list and groups from where the program last terminated

        while (running)
        {
            Console.WriteLine("Contact Manager");
            Console.WriteLine("1) Create Contact");
            Console.WriteLine("2) Search Contacts");
            Console.WriteLine("3) View Groups");
            Console.WriteLine("4) Create Group");
            Console.WriteLine("5) Edit Contact");
            Console.WriteLine("6) Add Contact to Group");
            Console.WriteLine("7) View All Contacts"); // implement code, ALPHABETIC ORDER

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
                case "5":
                    EditContact(manager);
                    break;
                case "6":
                    AddContactToGroup(manager);
                    break;
                case "7":
                    DisplayContactNames(manager);
                    break;
                case "x":
                    manager.SaveToFile(saveFile);
                    Console.WriteLine("Contacts saved.");
                    Console.WriteLine("Exiting the program...");
                    running = false;
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

        // General fields for PersonInfo
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

        // Gather unique fields for each contact type
        string relationship = null,
        company = null,
        job = null,
        school = null,
        major = null,
        mutualClasses = null,
        interests = null,
        interestLevel = null;
        int gradYear = 0;
        bool stillTalking = false;

        switch (type)
        {
            case "1":
                Console.Write("Relationship: ");
                relationship = Console.ReadLine();
                break;
            case "2":
                Console.Write("Company: ");
                company = Console.ReadLine();
                Console.Write("Job Position: ");
                job = Console.ReadLine();
                break;
            case "3":
                Console.Write("School Name: ");
                school = Console.ReadLine();
                Console.Write("Major: ");
                major = Console.ReadLine();
                Console.Write("Graduation Year: ");
                gradYear = int.TryParse(Console.ReadLine(), out int gy) ? gy : 0;
                Console.Write("Mutual Classes: ");
                mutualClasses = Console.ReadLine();
                break;
            case "4":
                Console.Write("Mutual Interests: ");
                interests = Console.ReadLine();
                Console.Write("Interest Level: ");
                interestLevel = Console.ReadLine();
                Console.Write("Still Talking (true/false): ");
                stillTalking = bool.TryParse(Console.ReadLine(), out bool st) ? st : false;
                break;
        }

        Contact contact = manager.CreateAndAddContact(type, info, relationship, company, job, school, major, gradYear, mutualClasses, interests, interestLevel, stillTalking);
        if (contact != null)
            Console.WriteLine("Contact added! Press Enter to continue...");
        else
            Console.WriteLine("Failed to add contact. Press Enter to continue...");
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

    static void EditContact(ContactManager manager)
    {
        Console.Write("Enter contact name to edit: ");
        string name = Console.ReadLine();
        Contact contact = manager.FindContactByName(name);
        if (contact != null)
        {
            Console.WriteLine("Editing contact details:");
            Console.Write("New Name: ");
            string newName = Console.ReadLine();
            Console.Write("New Phone Number: ");
            string newPhone = Console.ReadLine();
            Console.Write("New Email: ");
            string newEmail = Console.ReadLine();
            Console.Write("New Address: ");
            string newAddress = Console.ReadLine();
            Console.Write("New Birthday (MM/DD/YYYY): ");
            DateTime newBirthday = DateTime.TryParse(Console.ReadLine(), out DateTime bday) ? bday : DateTime.MinValue;

            contact.EditContactInfo(newName, newPhone, newEmail, newAddress, newBirthday);

            // Edit unique fields for Coworker, SchoolMate, DatingProspect
            if (contact is Coworker coworker)
            {
                Console.Write("New Company: ");
                string newCompany = Console.ReadLine();
                Console.Write("New Job Position: ");
                string newJob = Console.ReadLine();
                coworker.EditCoworkerDetails(newCompany, newJob);
            }
            else if (contact is SchoolMate schoolMate)
            {
                Console.Write("New School Name: ");
                string newSchool = Console.ReadLine();
                Console.Write("New Major: ");
                string newMajor = Console.ReadLine();
                Console.Write("New Graduation Year: ");
                int newGradYear = int.TryParse(Console.ReadLine(), out int gy) ? gy : 0;
                Console.Write("New Mutual Classes: ");
                string newMutualClasses = Console.ReadLine();
                schoolMate.EditSchoolMateDetails(newSchool, newMajor, newGradYear, newMutualClasses);
            }
            else if (contact is DatingProspect dating)
            {
                Console.Write("New Mutual Interests: ");
                string newInterests = Console.ReadLine();
                Console.Write("New Interest Level: ");
                string newInterestLevel = Console.ReadLine();
                Console.Write("Still Talking (true/false): ");
                bool newStillTalking = bool.TryParse(Console.ReadLine(), out bool st) ? st : false;
                dating.EditDatingDetails(newInterests, newInterestLevel, newStillTalking);
            }

            Console.WriteLine("Contact updated! Press Enter to continue...");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
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
        Console.WriteLine($"Group '{groupName}' created. Press Enter to continue...");
        Console.ReadLine();
    }

    static void AddContactToGroup(ContactManager manager)
    {
        Console.Write("Enter group name: ");
        string groupName = Console.ReadLine();
        ContactGroup group = manager.FindGroup(groupName);
        if (group == null)
        {
            Console.WriteLine("Group not found.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            return;
        }

        Console.Write("Enter contact name to add: ");
        string contactName = Console.ReadLine();
        Contact contact = manager.FindContactByName(contactName); // "...ByName" inculded because if expanded, I could also find contacts by phonenumber or other attributes.
        if (contact != null)
        {
            group.AddContact(contact);
            Console.WriteLine($"Contact '{contactName}' added to group '{groupName}'.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
    
    static void DisplayContactNames(ContactManager manager)
    {

        string names = manager.ListAllContacts();
        if (string.IsNullOrEmpty(names))
        {
            Console.WriteLine("No contacts available.");
            return;
        }
        Console.WriteLine(names);
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}