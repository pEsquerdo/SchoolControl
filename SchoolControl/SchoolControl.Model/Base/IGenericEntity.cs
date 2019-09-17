namespace SchoolControl.Model.Base
{
    public interface IGenericEntity
    {
        bool Active { get; set; }
        int Id { get; set; }
    }
}