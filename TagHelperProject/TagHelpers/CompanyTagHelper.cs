using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperProject.TagHelpers
{
    [HtmlTargetElement("company")]
    public class CompanyTagHelper : TagHelper
    {
        public string Name { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string preContent = @"
                <div class='card card-body' style='padding: 20px'>
                 <div class='card-header' style='margin-bottom:50px;'>
                    <img src='/images/{0}.jpg' height='20' />
                 </div>";

            const string postContent = @"</div>";

            output.TagName = "div";
            output.PreContent.SetHtmlContent(string.Format(preContent,Name));
            output.PostContent.SetHtmlContent(postContent);
        }
    }
}
