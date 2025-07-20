using System.Collections.Generic;

class ContactManager
{
    private List<Contact> _allContacts = new List<Contact>();
    private List<ContactGroup> _allGroups = new List<ContactGroup>();


    //constructor
    public ContactManager()
    {
    }

    // Add a contact
    public void AddContact(Contact contact)
    {
        if (contact != null && !_allContacts.Contains(contact))
        {
            _allContacts.Add(contact);
        }
    }

    // Find a contact by name
    public Contact FindContactByName(string name)
    {
        foreach (Contact contact in _allContacts)
        {
            if (contact.PersonContact.Name.ToLower() == name.ToLower())
                return contact;
        }
        return null;
    }

    // Add a group
    public void AddGroup(ContactGroup group)
    {
        if (group != null && !_allGroups.Contains(group))
        {
            _allGroups.Add(group);
        }
    }

    // Find a group by name
    public ContactGroup FindGroup(string groupName)
    {
        foreach (ContactGroup group in _allGroups)
        {
            if (group.GroupName.ToLower() == groupName.ToLower())
                return group;
        }
        return null;
    }

    // List all groups
    public List<ContactGroup> GetAllGroups()
    {
        return _allGroups;
    }

    public string ListAllContacts() // Alphabetized by names, and only display names
    {
        List<string> names = new List<string>();
        foreach (var contact in _allContacts)
        {
            names.Add(contact.PersonContact.Name);
        }
        names.Sort();
        return string.Join("\n", names);
    }

    // specifically for creating a new contact and adding them to a group of
    // the contact type without user interaction.
    public void AddNewContactToGroup(Contact contact)
    {
        if (contact == null) return;

        string groupName = contact.GetType().Name; // ex) "FamilyMember"
        ContactGroup group = FindGroup(groupName);
        if (group == null)
        {
            group = new ContactGroup(groupName);
            AddGroup(group);
        }
        group.AddContact(contact);
    }

    public void SaveToFile(string filePath) // We didn't learn JSON in class so I got help with this 
    // because I want to be able to save and load, so I admit I don't know exactly what is going on 
    // with the JSON here or in LoadFromFile below.
    {
        var options = new System.Text.Json.JsonSerializerOptions { WriteIndented = true };
        string json = System.Text.Json.JsonSerializer.Serialize(this, options);
        System.IO.File.WriteAllText(filePath, json);
    }

    public static ContactManager LoadFromFile(string filePath)
    {
        if (!System.IO.File.Exists(filePath))
            return new ContactManager();

        string json = System.IO.File.ReadAllText(filePath);
        return System.Text.Json.JsonSerializer.Deserialize<ContactManager>(json);
    }

    public Contact CreateAndAddContact( // I kept only the user interaction in the program class
        string type,
        PersonInfo info,
        string relationship = null,
        string company = null,
        string job = null,
        string school = null,
        string major = null,
        int gradYear = 0,
        string mutualClasses = null,
        string interests = null,
        string interestLevel = null,
        bool stillTalking = false)

    {
        Contact contact = null;
        switch (type)
        {
            case "1":
                contact = new FamilyMember(info, relationship);
                break;
            case "2":
                contact = new Coworker(info, company, job);
                break;
            case "3":
                contact = new SchoolMate(info, school, major, gradYear, mutualClasses);
                break;
            case "4":
                contact = new DatingProspect(info, interests, interestLevel, stillTalking);
                break;
        }
        if (contact != null)
        {
            AddContact(contact);
            AddNewContactToGroup(contact);
        }
        return contact;
    }
}