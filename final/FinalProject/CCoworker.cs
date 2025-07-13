class Coworker : Contact
{
    private string _company;
    private string _jobPosition;

    public Coworker(PersonInfo personContact, string company, string jobPosition) : base(personContact)
    {
        _company = company;
        _jobPosition = jobPosition;
    }

    // Edit only PersonInfo details
    public override void EditContactInfo(string name, string phone, string email, string address, DateTime birthday)
    {
        base.EditContactInfo(name, phone, email, address, birthday);
    }

    // Edit only Coworker-specific details
    public void EditCoworkerDetails(string company, string jobPosition)
    {
        _company = company;
        _jobPosition = jobPosition;
    }

    public override string GetContactDetails()
    {
        return base.GetContactDetails() +
               $"\nCompany: {_company}\nPosition: {_jobPosition}";
    }
}