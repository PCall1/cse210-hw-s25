abstract class Contact
{
    protected PersonInfo _personContact;

    protected Contact(PersonInfo personContact)
    {
        _personContact = personContact;
    }

    public PersonInfo PersonContact
    {
        get { return _personContact; }
    }

    public virtual string GetContactDetails()
    {
        List<string> details = new List<string>
        {
            $"Name:    {_personContact.Name}",
            $"Phone:   {_personContact.PhoneNumber}",
            $"Email:   {_personContact.Email}",
            $"Address: {_personContact.Address}",
            $"Birthday: {_personContact.Birthday.ToShortDateString()}"
        };
        return string.Join("\n", details);
    }

    // Virtual method for editing contact info
    public virtual void EditContactInfo(string name, string phone, string email, string address, DateTime birthday)
    {
        _personContact.UpdatePersonInfo(name, phone, email, address, birthday);
    }
}