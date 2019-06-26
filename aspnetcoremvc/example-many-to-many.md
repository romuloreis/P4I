```cs    
    
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Categorization> Categorizations { get; set; }
    }
    
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public ICollection<Categorization> Categorizations { get; set; }
    }
    
    
    public class Categorization
    {   
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
     }
     
     
    /*DBCONTEXT*/
        public DbSet<Relation.Models.Category> Categories { get; set; }

        public DbSet<Relation.Models.Product> Products { get; set; }

        public DbSet<Relation.Models.Categorization> Categorizations { get; set; }
        /*romulo*/
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Categorization>().HasKey(c => new {c.CategoryId, c.ProductId});
        }
        
        ```
