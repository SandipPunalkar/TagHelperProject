using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperProject.TagHelpers
{
    //[HtmlTargetElement("employee", Attributes ="name,title",ParentTag ="comapny")]
    public class EmployeeTagHelper : TagHelper
    {
        public string Name { get; set; }
        public string Title { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            string content = @"
                <div class='card card-body' style='margin-top: 10px'>
                   <img class='img-fluid' src='/images/{0}.jpg' style='float:left; margin-right:10px' />
                   <p class='list-group-item'>{0}<br/><i>{1}</i></p>   
                </div>";


            output.Content.SetHtmlContent(string.Format(content, Name.Replace(" ", "-"), Title));
        }
    }
}
