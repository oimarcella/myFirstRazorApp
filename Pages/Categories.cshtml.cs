using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages;
public class Categories : PageModel
{
    public int Total { get; set; } = 0;
    public List<Category> CategoriesList { get; set; } = new();
    public void OnGet(int pageNumber = 1, int take = 15)
    {// Executado sempre que a página for renderizada, ou seja quando for feito GET

        var auxList = new List<Category>();

        for (int i = 0; i <= 1787; i++)
        {
            auxList.Add(new Category(i, $"Categoria-{i}", i * 18.95M));
        }

        Total = auxList.Count;
        var skip = (pageNumber - 1) * take;
        CategoriesList = auxList.Skip(skip).Take(take).ToList();
    }

    public void OnPost()
    {// Executado quando enviar uma informação na página, ou seja, quando for feito POST
    }
}

public record Category(int Id, string Title, decimal Price);

