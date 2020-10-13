using Microsoft.AspNetCore.Authentication;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NesopsRTC2.Models
{
    public class AuthorizeModel
    {
        public IDictionary<string, string> errors { get; } = new Dictionary<string, string>();
        public bool valid { get; set; } = true;
        public AuthenticationTicket ticket { get; private set; }
        public void Validated(AuthenticationTicket _ticket)
        {
            ticket = _ticket;
        }
        public void SetError(string name, string value)
        {
            errors[name] = value;
        }
        public void Rejected()
        {
            valid = false;
        }
    }

    public class LoginModel
    {
        [JsonProperty("username")]
        public string username { get; set; }
        [JsonProperty("password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
    public class CheckTokenResponseViewModel
    {
        public string User { get; set; }
        public string UserId { get; set; }
        public string Role { get; set; }
        public IDictionary<string, IEnumerable<string>> Claims { get; }

        public CheckTokenResponseViewModel(ClaimsPrincipal user)
        {
            Claims = new Dictionary<string, IEnumerable<string>>(user.Claims.GroupBy(c => c.Type)
                .Select(group => new KeyValuePair<string, IEnumerable<string>>(
                    group.Key, group.Select(c => c.Value).ToList())));
            UserId = user.FindFirst(ClaimTypes.NameIdentifier).Value;
            User = user.Identity.Name;
            Role = user.FindFirst(ClaimTypes.Role).Value;
        }
    }
}
