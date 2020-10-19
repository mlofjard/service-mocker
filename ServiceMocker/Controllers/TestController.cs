using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Dynamic;

namespace ServiceMocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public ActionResult<string> Get()
        {
            var authHeaderCheck = Request.Headers.TryGetValue("authorization", out var authenticationHeader);
            if (!authHeaderCheck)
            {
                return new BadRequestObjectResult("No authorization header found.");
            }

            var token = authenticationHeader.ToString().Replace("Bearer: ", string.Empty);

            if (!Program.MainForm.allowedTokensCheckedListBox.Items.Contains(token))
            {
                Program.MainForm.Invoke(new Action(() =>
                {
                    Program.MainForm.allowedTokensCheckedListBox.Items.Add(token, Program.MainForm.autoAllowCheckBox.Checked);
                }));
            }

            int index = Program.MainForm.allowedTokensCheckedListBox.FindStringExact(token);
            if (!Program.MainForm.allowedTokensCheckedListBox.GetItemChecked(index))
            {
                return new UnauthorizedObjectResult("Invalid token");
            }

            string text = "";
            Program.MainForm.Invoke(new Action(() =>
            {
                text = Program.MainForm.responseTextBox.Text;
            }));
            return new JsonResult(JsonConvert.DeserializeObject<ExpandoObject>(text, new ExpandoObjectConverter()));
        }
    }
}
