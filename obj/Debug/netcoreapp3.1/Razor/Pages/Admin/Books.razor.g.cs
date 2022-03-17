#pragma checksum "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/Books.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "477d1e69f6afada71f8d34dc57be3a1c91a2c67f"
// <auto-generated/>
#pragma warning disable 1591
namespace Sundaland.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/_Imports.razor"
using Sundaland.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Books : OwningComponentBase<IBookstoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\n\n    ");
            __builder.AddMarkupContent(3, "<thead>\n        <tr>\n            <th>ID</th>\n            <th>Title</th>\n            <th>Author</th>\n        </tr>\n    </thead>\n\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 16 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/Books.razor"
         if (BookData?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/Books.razor"
             foreach (Book b in BookData)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\n                    ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 21 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/Books.razor"
__builder.AddContent(10, b.BookId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n                    ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 22 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/Books.razor"
__builder.AddContent(13, b.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 23 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/Books.razor"
__builder.AddContent(16, b.Author);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "btn btn-secondary btn-sm");
            __builder.AddAttribute(22, "href", 
#nullable restore
#line 26 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/Books.razor"
                                                                     GetDetailsUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(24, "Details");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(28, "href", 
#nullable restore
#line 27 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/Books.razor"
                                                                   GetEditUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(30, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
            __builder.AddAttribute(33, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/Books.razor"
                                                                       x => RemoveBook(b)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(36, "Delete");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n");
#nullable restore
#line 31 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/Books.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/Books.razor"
         
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "            ");
            __builder.AddMarkupContent(41, "<tr>\n                <td colspan=\"5\" class=\"text-center\">No Books</td>\n            </tr>\n");
#nullable restore
#line 38 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/Books.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
            __builder.AddAttribute(46, "class", "btn btn-primary");
            __builder.AddAttribute(47, "href", "/admin/books/create");
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(49, "Create");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/Users/tschoeny/Documents/~BYU Winter 2022/413 - Enterprise Application Development/Sundaland/Sundaland/Pages/Admin/Books.razor"
       
    public IBookstoreRepository repo => Service;

    public IEnumerable<Book> BookData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        BookData = await repo.Books.ToListAsync();
    }

    public string GetDetailsUrl(long id) => $"/admin/books/details/{id}";
    public string GetEditUrl(long id) => $"/admin/books/edit/{id}";
    public async Task RemoveBook(Book b)
    {
        repo.DeleteBook(b);
        await UpdateData();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
