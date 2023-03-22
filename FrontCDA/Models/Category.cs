
using System.ComponentModel.DataAnnotations;

namespace FrontCDA.Models
{
    public class Category
    {
        private Guid _id = Guid.NewGuid();
        private string _name;

        public Guid id
        {
            get { return _id; }
        }
        
        public string name { get => _name; set => _name = value; }
    }
}
