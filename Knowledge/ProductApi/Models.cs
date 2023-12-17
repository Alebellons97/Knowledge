namespace ProductApi
{
    public class Product
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int IdCatalogo { get; set; }

    }

    public class Category
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TipologiaProdotti { get; set; }
    }


    public class Repository
    {

        List<Category> _categories = new List<Category>() { new Category() { Id = 0, Nome = "Vino", TipologiaProdotti = "Alimentari" } };
        List<Product> _products = new List<Product>() { new Product() { Id = 0, Nome = "Tavernello", Descrizione = "Vino in cartone", Prezzo = 0.5, IdCatalogo = 0 } };

        public List<Product> GetAllProducts()
        {
            return this._products;
        }

        public List<Category> GetAllCategories()
        {
            return this._categories;
        }

        public Product GetProduct(int productId)
        {
            return this._products.SingleOrDefault(p => p.Id == productId);
        }

        public Category GetCategory(int categoryId)
        {
            return this._categories.SingleOrDefault(p => p.Id == categoryId);
        }

        public void AddProduct(Product product)
        {
            if(!_categories.Any(c => c.Id == product.IdCatalogo)) throw new InvalidOperationException("Categoria inesistente");
            this._products.Add(product);
        }

        public void AddCategory(Category category)
        {
            this._categories.Add(category);
        }

        public void DeleteProduct(int productId)
        {
            if(!_products.Any(c => c.Id == productId)) throw new InvalidOperationException("Prodotto inesistente");
            this._products.Remove(this._products.Single(p => p.Id == productId));
        }

        public void DeleteCategory(int categoryId)
        {
            if(!_categories.Any(c => c.Id == categoryId)) throw new InvalidOperationException("Categoria inesistente");
            if(!_products.Any(c => c.IdCatalogo == categoryId)) throw new InvalidOperationException("Impossibile eliminare la categoria: prodotti associati");
            this._categories.Remove(this._categories.Single(p => p.Id == categoryId));
        }

        public void UpdateProduct(Product product)
        {
            if(!_products.Any(c => c.Id == product.Id)) throw new InvalidOperationException("Prodotto inesistente");
            this._products.Remove(this._products.Single(p => p.Id == product.Id));
            this._products.Add(product);
        }

        public void UpdateCategory(Category category)
        {
            if(!_categories.Any(c => c.Id == category.Id)) throw new InvalidOperationException("Categoria inesistente");
            this._categories.Remove(this._categories.Single(p => p.Id == category.Id));
            this._categories.Add(category);
        }



    }
}
