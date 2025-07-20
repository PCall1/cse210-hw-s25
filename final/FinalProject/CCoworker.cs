class Coworker : Contact
{
    private string _company;
    private string _jobPosition;

    public Coworker(PersonInfo personContact, string company, string jobPosition) : base(personContact)
    {
        _company = company;
        _jobPosition = jobPosition;
    }

    // Edit Coworker-specific details
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