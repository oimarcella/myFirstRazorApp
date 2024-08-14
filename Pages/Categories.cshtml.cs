using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages;
public class Categories : PageModel
{
    public List<Category> CategoriesList { get; set; } = new();
    public void OnGet()
    {// Executado sempre que a página for renderizada, ou seja quando for feito GET

        for (int i = 0; i <= 100; i++)
        {
            CategoriesList.Add(new Category(i, $"Categoria-{i}", i * 18.95M));
        }
    }

    public void OnPost()
    {// Executado quando enviar uma informação na página, ou seja, quando for feito POST
    }
}

public record Category(int Id, string Title, decimal Price);

