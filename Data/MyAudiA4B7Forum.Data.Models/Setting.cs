namespace MyAudiA4B7Forum.Data.Models
{
    using MyAudiA4B7Forum.Data.Common.Models;

    public class Setting : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
