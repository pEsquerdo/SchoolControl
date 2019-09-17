namespace SchoolControl.Model.Base
{
    public interface IUser: IGenericEntity
    {
        string Address { get; set; }
        string Email { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        string Phone { get; set; }
    }
}