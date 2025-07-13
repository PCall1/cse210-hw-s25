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

    // Remove a contact
    public void RemoveContact(Contact contact)
    {
        _allContacts.Remove(contact);
        foreach (ContactGroup group in _allGroups)
        {
            group.RemoveContact(contact);
        }
    }

    // Search contacts by name (simple search)
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

    // Remove a group
    public void RemoveGroup(ContactGroup group)
    {
        _allGroups.Remove(group);
    }

    // List all contacts
    public List<Contact> GetAllContacts()
    {
        return _allContacts;
    }

    // List all groups
    public List<ContactGroup> GetAllGroups()
    {
        return _allGroups;
    }
}