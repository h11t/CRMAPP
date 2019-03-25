using IsmekCrm.Entity.Concrete;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsmekCrm.Ui.TagHelpers
{
    [HtmlTargetElement("status-helper")]
    public class StatusTagHelper:TagHelper
    {
        private const string ForAttributeName = "asp-for";
        [HtmlAttributeName("status-list")]
        public List<Status> List { get; set; }

        [HtmlAttributeName("asp-for")]
        public int Id { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //string data = "<select>";
            //foreach (var item in List)
            //{
            //    data += "<option value=" + item.Id + ">" + item.Name + "</option>";
            //}
            //data += "</select>";
            //output.Content.Append(data); output.content.sethtmlcontent(data);

            output.TagName = "select";
            output.Attributes.Add("class", "form-control");
            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();
            foreach (var item in List)
            {
                sb.AppendFormat("<option value={0}>{1}</option>", item.Id, item.Name);
            }
            output.PreContent.SetHtmlContent(sb.ToString());
        }
    }
}
