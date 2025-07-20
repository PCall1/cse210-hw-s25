class SchoolMate : Contact
{
    //Attributes
    private string _schoolName;
    private string _major;
    private int _gradYear;
    private string _mutualClasses;


    //Constructor
    public SchoolMate(PersonInfo personContact, string schoolName, string major, int gradYear, string mutualClasses = "")
        : base(personContact)
    {
        _schoolName = schoolName;
        _major = major;
        _gradYear = gradYear;
        _mutualClasses = mutualClasses;
    }


    // Edit SchoolMate-specific details
    public void EditSchoolMateDetails(string schoolName, string major, int gradYear, string mutualClasses)
    {
        _schoolName = schoolName;
        _major = major;
        _gradYear = gradYear;
        _mutualClasses = mutualClasses;
    }

    public override string GetContactDetails()
    {
        return base.GetContactDetails() +
               $"\nSchool: {_schoolName}\nMajor: { _major}\nGraduation Year: {_gradYear}\nMutual Classes: {_mutualClasses}";
    }
}