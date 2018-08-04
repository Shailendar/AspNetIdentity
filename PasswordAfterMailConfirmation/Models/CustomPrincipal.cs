using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace PasswordAfterMailConfirmation.Models
{
    interface ICustomPrincipal : IPrincipal
    {
        int Id { get; set; }
        string Email { get; set; }
        string Role { get; set; }
    }
    public class CustomPrincipal : ICustomPrincipal
    {
        public IIdentity Identity { get; private set; }
        public bool IsInRole(string role) { return false; }
        public CustomPrincipal(string email)
        {
            this.Identity = new GenericIdentity(email);
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
    public class CustomPrincipalSerializeModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}