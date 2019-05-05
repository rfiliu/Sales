namespace Sales.ViewModels
{ 

    public class MainViewModel
    {
        public ProductsViewModel ProductsVM { get; set; }

        public MainViewModel()
        {
            this.ProductsVM = new ProductsViewModel();
        }
    }
}
