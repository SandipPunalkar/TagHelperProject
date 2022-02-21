using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperProject.TagHelpers
{
    //[HtmlTargetElement("tag-name")]
    public class SpaeakerCardTagHelper:TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "strong";
            output.Content.SetHtmlContent($"Date: { DateTime.Now}");
        }
    }
}
