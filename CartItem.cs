namespace Nesne_programlama_odev2;

public class CartItem
{
    public int Id { get; set; }
    public Product Product { get; set; } = null!;
    public int Quantity { get; set; }

    public override string ToString()
    {
        return $" Ürün Adı : {Product.ProductName}\n" +
               $" Fiyat : {Product.Price} \n " +
               $"Adet : {Quantity} \n";
    }
}