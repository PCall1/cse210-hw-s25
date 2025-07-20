class FamilyMember : Contact
{
    private string _relationship;

    public FamilyMember(PersonInfo personContact, string relationship) : base(personContact)
    {
        _relationship = relationship;
    }

    public override string GetContactDetails()
    {
        return base.GetContactDetails() + $"\nRelationship: {_relationship}";
    }
}