#pragma checksum "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7cd0eb96464128c1da87b4a7e90ce23a3ed3fb0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorUI.Pages.Contacts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\_Imports.razor"
using BlazorUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\_Imports.razor"
using BlazorUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
using PeopleLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
using PeopleLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
using BlazorUI.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Contacts/People/")]
    public partial class People : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>People List</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>Insert new person:</h4>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
                  newPerson

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
                                             InsertPerson

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n\r\n    ");
                __builder2.AddMarkupContent(11, "<label for=\"firstName\">First Name</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "firstName");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
                                           newPerson.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.FirstName = __value, newPerson.FirstName))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.AddMarkupContent(18, "<label for=\"lastName\">Last Name</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "id", "lastName");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
                                          newPerson.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.LastName = __value, newPerson.LastName))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.AddMarkupContent(25, "<label for=\"phoneNumber\">Phone Number</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "id", "phoneNumber");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
                                             newPerson.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.PhoneNumber = __value, newPerson.PhoneNumber))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n\r\n    ");
                __builder2.AddMarkupContent(32, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n\r\n");
            __builder.AddMarkupContent(34, "<h4>Current People</h4>\r\n\r\n");
#nullable restore
#line 29 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
 if(people is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "    ");
            __builder.AddMarkupContent(36, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 32 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "    ");
            __builder.OpenElement(38, "table");
            __builder.AddAttribute(39, "class", "table table-striped");
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.AddMarkupContent(41, "<thead>\r\n            <tr>\r\n                <th>First Name</th>\r\n                <th>Last Name</th>\r\n                <th>Phone Number</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(42, "tbody");
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 44 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
             foreach (var person in people)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                ");
            __builder.OpenElement(45, "tr");
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "th");
            __builder.AddContent(48, 
#nullable restore
#line 47 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
                         person.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "th");
            __builder.AddContent(51, 
#nullable restore
#line 48 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
                         person.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "th");
            __builder.AddContent(54, 
#nullable restore
#line 49 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
                         person.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 51 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 54 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\ibeje\Desktop\GitHub\ContactListBlazorApp\BlazorUI\Pages\Contacts\People.razor"
       
    private List<PersonModel> people;
    private DisplayPersonModel newPerson = new DisplayPersonModel();
    protected override async Task OnInitializedAsync()
    {
        people = await _db.GetPeople();
    }

    private async Task InsertPerson()
    {
        PersonModel p = new PersonModel
        {
            FirstName = newPerson.FirstName,
            LastName = newPerson.LastName,
            PhoneNumber = newPerson.PhoneNumber
        };
        await _db.InsertPerson(p);

        people.Add(p);

        newPerson = new DisplayPersonModel();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeople _db { get; set; }
    }
}
#pragma warning restore 1591
