using System;

/// <summary>
/// Info class: stores a persons information.
/// </summary>
class PersonInfo
{
    private string _name;
    private string _phoneNumber;
    private string _email;
    private string _address;
    private DateTime _birthday;


    // Constructors
    public PersonInfo(string name)
    {
        _name = name;
        _phoneNumber = string.Empty;
        _email = string.Empty;
        _address = string.Empty;
        _birthday = DateTime.MinValue;
    }
    public PersonInfo(string name, string phone, string email, string address)
    {
        _name = name;
        _phoneNumber = phone;
        _email = email;
        _address = address;
        _birthday = DateTime.MinValue;
    }
    public PersonInfo(string name, string phone, string email, string address, DateTime birthday)
    {
        _name = name;
        _phoneNumber = phone;
        _email = email;
        _address = address;
        _birthday = birthday;
    }


    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string PhoneNumber
    {
        get { return _phoneNumber; }
        set { _phoneNumber = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public DateTime Birthday
    {
        get { return _birthday; }
        set { _birthday = value; }
    }



    public void UpdatePersonInfo(string name, string phone, string email, string address, DateTime birthday)
    {
        _name = name;
        _phoneNumber = phone;
        _email = email;
        _address = address;
        _birthday = birthday;
    }
}