using System.Collections.Generic;

class ContactGroup
{
    private string _groupName;
    private List<Contact> _contacts;

    public ContactGroup(string groupName)
    {
        _groupName = groupName;
        _contacts = new List<Contact>();
    }

    public string GroupName
    {
        get { return _groupName; }
        set { _groupName = value; }
    }

    public List<Contact> Contacts
    {
        get { return _contacts; } 
    }

    public void AddContact(Contact contact)
    {
        if (contact != null && !_contacts.Contains(contact))
        {
            _contacts.Add(contact);
        }
    }

    public void RemoveContact(Contact contact)
    {
        _contacts.Remove(contact);
    }

    public string ListContacts()
    {
        if (_contacts.Count == 0)
            return "No contacts in this group.";

        string result = $"Contacts in '{_groupName}':\n";
        foreach (Contact contact in _contacts)
        {
            result += contact.GetContactDetails() + "\n---\n";
        }
        return result;
    }
}