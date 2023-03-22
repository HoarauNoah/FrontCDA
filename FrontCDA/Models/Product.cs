
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FrontCDA.Models
{
    public class Product
    {
        private Guid _id;
        private string _name;
        private string _description;
        private float _price;
        private int _stock;
        private Guid _categoryId;
        private Guid _supplierId;


        private Supplier _supplier;
        private Category _category;
       
        [Key]
        public Guid id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string name { get => _name; set => _name = value; }
        public string description { get => _description; set => _description = value; }

        public float price { get => _price; set => _price = value; }
        public int stock { get => _stock; set => _stock = value; }
        public Guid CategoryId { get => _categoryId; set => _categoryId = value; }
        public Guid SupplierId { get => _supplierId; set => _supplierId = value; }
        public Supplier Supplier { get => _supplier; set => _supplier = value; }
        public Category Category { get => _category; set => _category = value; }
    }
}


