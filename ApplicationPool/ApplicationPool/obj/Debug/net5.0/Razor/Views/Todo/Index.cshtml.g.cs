#pragma checksum "C:\Users\yazilim.park2\source\repos\ApplicationPool\ApplicationPool\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0424558612674bba2b1829f757c24487ee255e56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\yazilim.park2\source\repos\ApplicationPool\ApplicationPool\Views\_ViewImports.cshtml"
using ApplicationPool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yazilim.park2\source\repos\ApplicationPool\ApplicationPool\Views\_ViewImports.cshtml"
using ApplicationPool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0424558612674bba2b1829f757c24487ee255e56", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6714e90bb32c1e87e41d03020c065e06fabfd0ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ToDoModel>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0424558612674bba2b1829f757c24487ee255e563551", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css"" integrity=""sha512-iBBXm8fW90+nuLcSKlbmrPcLa0OT92xO1BIsZ+ywDWZCvqsWgccV3gFoRBv0z+8dLJgyAHIhR35VZc2oM/gI1w=="" crossorigin=""anonymous"" />
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Poppins&display=swap"" rel=""stylesheet"">
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Todo List</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0424558612674bba2b1829f757c24487ee255e565144", async() => {
                WriteLiteral("\r\n    <h1>Todo list</h1>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0424558612674bba2b1829f757c24487ee255e565432", async() => {
                    WriteLiteral("\r\n        <input type=\"text\" class=\"todo-input\">\r\n        <button class=\"todo-button\" type=\"submit\" style=\"padding: 2rem;\"><i class=\"fas fa-plus\"></i></button>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"todo-container\">\r\n        <ul class=\"todo-list\">\r\n");
#nullable restore
#line 21 "C:\Users\yazilim.park2\source\repos\ApplicationPool\ApplicationPool\Views\Todo\Index.cshtml"
             foreach (var todo in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div");
                BeginWriteAttribute("key", " key=\"", 1002, "\"", 1016, 1);
#nullable restore
#line 23 "C:\Users\yazilim.park2\source\repos\ApplicationPool\ApplicationPool\Views\Todo\Index.cshtml"
WriteAttributeValue("", 1008, todo.Id, 1008, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"todo\">\r\n                <li class=\"todo-item\">");
#nullable restore
#line 24 "C:\Users\yazilim.park2\source\repos\ApplicationPool\ApplicationPool\Views\Todo\Index.cshtml"
                                 Write(todo.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                <button class=\"complete-btn\"><i class=\"fas fa-check\"></i></button>\r\n                <button class=\"trash-btn\"><i class=\"fas fa-trash\"></i></button>\r\n                </div>\r\n");
#nullable restore
#line 28 "C:\Users\yazilim.park2\source\repos\ApplicationPool\ApplicationPool\Views\Todo\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </ul>\r\n            </div>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <script>

            //selectors
            const todoInput = document.querySelector("".todo-input"");
            const todoButton = document.querySelector("".todo-button"");
            const todoList = document.querySelector("".todo-list"");

            //event listeners
            todoButton.addEventListener(""click"", addTodo);
            todoList.addEventListener(""click"", deleteCheck);

            //functions
          async  function addTodo(event) {
                event.preventDefault();//prevent form from submitting
                const model = {name: todoInput.value}
              const res = await fetch('https://localhost:5001/api/todo', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(model)
                });
              if (res.status != 200) {
                  return;
              }
                const data = a");
            WriteLiteral(@"wait res.json();
                console.log(data)
                
                //Todo DIV
                const todoDiv = document.createElement(""div"");
              todoDiv.classList.add(""todo"");
              todoDiv.setAttribute(""key"",data.id)

                //create li
              const newTodo = document.createElement(""li"");
              newTodo.innerText = data.name;
                newTodo.classList.add(""todo-item"");
                todoDiv.appendChild(newTodo);

                //checked/ task complete button
                const completedButton = document.createElement(""button"");
                completedButton.innerHTML = '<i class=""fas fa-check""></i>';
                completedButton.classList.add(""complete-btn"");
                todoDiv.appendChild(completedButton);

                //delete button
                const trashButton = document.createElement(""button"");
                trashButton.innerHTML = '<i class=""fas fa-trash""></i>';
                trashButt");
            WriteLiteral(@"on.classList.add(""trash-btn"");
                todoDiv.appendChild(trashButton);

                //APPEND TODO TO THE LIST
                todoList.appendChild(todoDiv);

                //clear todo input
                todoInput.value = """";
            }

            async function deleteCheck(e) {

                const id = e.target.parentElement.getAttribute(""key"")
                const res = await fetch('https://localhost:5001/api/todo/' + id, {
                    method: 'DELETE'
                });
                if (res.status != 200) {
                    return;
                }
                const item = e.target; //get the item we are clicking on
                //DELETE TODO
                if (item.classList[0] === ""trash-btn"") {
                    const todo = item.parentElement;
                    //animation
                    todo.classList.add(""fall"");
                    //delete when animation ends
                    todo.addEventListener(""transitione");
            WriteLiteral(@"nd"", function () {
                        todo.remove();
                    });
                }

                //CHECK MARK
                if (item.classList[0] === ""complete-btn"") {
                    const todo = item.parentElement;
                    todo.classList.toggle(""completed"");
                }
            }
            
            async function updateCheck(e){
              const id = e.target.parentElement.getAttribute(""key"");
                const res = await fetch('https://localhost:5001/api/todo/' + id, {
                method: 'UPDATE'
                });
                
                 if (res.status != 200) {
                                    return;
                                }
                                const item = e.target; //get the item we are clicking on
                                //DELETE TODO
                                if (item.classList[0] === ""trash-btn"") {
                                    const todo = item.parentEle");
            WriteLiteral(@"ment;
                                    //animation
                                    todo.classList.add(""fall"");
                                    //delete when animation ends
                                    todo.addEventListener(""transitionend"", function () {
                                        todo.remove();
                                    });
                                }
                
                                //CHECK MARK
                                if (item.classList[0] === ""complete-btn"") {
                                    const todo = item.parentElement;
                                    todo.classList.toggle(""completed"");
                                }
            }


        </script>


");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n            <link href=\"/css/todo.css\" rel=\"stylesheet\" />\r\n        ");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ToDoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
